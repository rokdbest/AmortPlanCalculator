using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;

namespace amort_nacrt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void izracunaj_Click(object sender, EventArgs e)
        {
            PreverjanjeRazred preveri = new PreverjanjeRazred();

            preveri.preveriOznakoNalozbe(oznakaNalozbe.Text);
            preveri.PreveriCeJePrazno(obrestnaMeraBox.Text, stKuponovBox.Text, nominalaBox.Text);
            preveri.PoglejDatum(zacetniDatumBox.Text, zapadlostBox.Text);
            decimal obMera = preveri.PreveriObrestnoMero(obrestnaMeraBox.Text);
            int steviloKuponov = preveri.preveriKupon(Convert.ToInt32(stKuponovBox.Text));
            decimal nominala = preveri.preveriNominalo(nominalaBox.Text);

            IzracunRazred Izracunaj = new IzracunRazred();

            var seznamVsehDatumov = Izracunaj.SeznamDatumov(zacetniDatumBox.Text, zapadlostBox.Text, steviloKuponov);
            int steviloVsehPlacil = seznamVsehDatumov.Count - 1; //stevilo vseh placil je seznamdatumov.count (zadnji v seznamu)
            var pmtMain = Izracunaj.Pmt(nominala, steviloVsehPlacil , obMera); //pmt/pmtMain je fiksno placilo za vso obdobje

            decimal izplaciloObresti, znizanaGlavnica, glavnica, novaGlavnica;
            glavnica = nominala;


            Controls.Add(dataGridPrikaz);
            dataGridPrikaz.ColumnCount = 5;
            dataGridPrikaz.Columns[0].Name = "Date of interest";
            dataGridPrikaz.Columns[1].Name = "Principal payment";
            dataGridPrikaz.Columns[2].Name = "Interest payment";
            dataGridPrikaz.Columns[3].Name = "Principal value";
            dataGridPrikaz.Columns[4].Name = "Remaining principal";


            for (int i = 0; i < steviloVsehPlacil; i++) //pazi -1 zaradi loopa 
            {
                ArrayList vrstica = new ArrayList();

                izplaciloObresti = Izracunaj.IzplaciloObresti(glavnica, obMera);

                znizanaGlavnica = Izracunaj.ZnizanjeGlavnice(pmtMain, izplaciloObresti);

                novaGlavnica = Izracunaj.IzracunNoveGlavnice(glavnica, znizanaGlavnica);


                vrstica.Add(seznamVsehDatumov[i + 1]); // i+1 ker ne placas obroka 1.mesec, ko vzames kredit
                vrstica.Add(Math.Round(znizanaGlavnica, 2));
                vrstica.Add(Math.Round(izplaciloObresti, 2));
                vrstica.Add(Math.Round(glavnica, 2));
                vrstica.Add(Math.Round(novaGlavnica, 2));

                dataGridPrikaz.Rows.Add(vrstica.ToArray());

                glavnica = novaGlavnica;
            }
        }

        private void shrani_Click(object sender, EventArgs e)
        {
            //extension dapper. ne rabis nic zapirat in to - samo using(IDbConnection...
            PreverjanjeRazred preveri = new PreverjanjeRazred();
            preveri.PreveriCeJePrazno2(obrestnaMeraBox.Text, stKuponovBox.Text, nominalaBox.Text);

            var sqlNizPovezava = new SqlConnection(Helper.ConnectionVal("AmortNacrtPovezava"));

            for (int i = 0; i < dataGridPrikaz.Rows.Count; i++)
            {
                sqlNizPovezava.Open();

                using (var sqlUkaz = new SqlCommand(@"INSERT INTO AmortPlanCoupT (Id_kupona, AmortPlanID, CoupDate,
                Payment, Interest, Principal, NewPrincipal) VALUES(@Id_kupona, @AmortPlanID, @CoupDate,
                @Payment, @Interest, @Principal, @NewPrincipal)", sqlNizPovezava))
                {
                    sqlUkaz.Parameters.Add("@Id_kupona", SqlDbType.Int).Value = i+1;
                    sqlUkaz.Parameters.Add("@AmortPlanID", SqlDbType.Int).Value = i+1001;
                    sqlUkaz.Parameters.Add("@CoupDate", SqlDbType.DateTime).Value = Convert.ToDateTime(dataGridPrikaz.Rows[i].Cells[0].Value);
                    sqlUkaz.Parameters.Add("@Payment", SqlDbType.Float).Value = dataGridPrikaz.Rows[i].Cells[1].Value;
                    sqlUkaz.Parameters.Add("@Interest", SqlDbType.Float).Value = dataGridPrikaz.Rows[i].Cells[2].Value;
                    sqlUkaz.Parameters.Add("@Principal", SqlDbType.Float).Value = dataGridPrikaz.Rows[i].Cells[3].Value;
                    sqlUkaz.Parameters.Add("@NewPrincipal", SqlDbType.Float).Value = dataGridPrikaz.Rows[i].Cells[4].Value;

                    sqlUkaz.ExecuteNonQuery();
                } 
                sqlNizPovezava.Close();
            }
            MessageBox.Show("Data was saved successfuly");

        }
        
        private void zapri_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           try
            {
                string danes = DateTime.Now.ToString("dd/MM/yyyy");
                zacetniDatumBox.Text = danes;
                zapadlostBox.Text = danes;
            }
            catch(Exception napacenCas)
            {
                MessageBox.Show(napacenCas.Message);
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            dataGridPrikaz.DataSource = null;
            dataGridPrikaz.Columns.Clear();
            dataGridPrikaz.Rows.Clear();
            dataGridPrikaz.Refresh();
        }

        private void PokaziBazo_Click(object sender, EventArgs e)
        {
            if (dataGridPrikaz != null)
            {
                dataGridPrikaz.Columns.Clear();
                dataGridPrikaz.Rows.Clear();
                dataGridPrikaz.Refresh();
            }
            dataGridPrikaz.DataSource = PodatkiIzBazeQuery();
        }

        private DataTable PodatkiIzBazeQuery()
        {
            var tabelaPodatkov = new DataTable();

            string sqlNizPovezava = ConfigurationManager.ConnectionStrings["AmortNacrtPovezava"].ConnectionString;

            using(SqlConnection sqlPovezava = new SqlConnection(sqlNizPovezava))
            {
                using (SqlCommand sqlUkaz = new SqlCommand("SELECT * FROM AmortPlanCoupT", sqlPovezava))
                {
                    sqlPovezava.Open();
                    SqlDataReader sqlReader = sqlUkaz.ExecuteReader();
                    tabelaPodatkov.Load(sqlReader);
                }
            }
            return tabelaPodatkov;
        }
        private void PocistiDB_Click(object sender, EventArgs e)
        {
            var sqlNizPovezava = new SqlConnection(Helper.ConnectionVal("AmortNacrtPovezava"));
            sqlNizPovezava.Open();
            var sqlAdapter = new SqlDataAdapter("delete FROM AmortPlanCoupT",sqlNizPovezava);
            sqlAdapter.SelectCommand.ExecuteNonQuery();
            sqlNizPovezava.Close();
            MessageBox.Show("Data from database deleted");
        }
        //class
    }
}
