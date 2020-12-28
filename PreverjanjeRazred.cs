using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace amort_nacrt_2
{

    class PreverjanjeRazred
    {
        public void PreveriCeJePrazno(string podatek1, string podatek2, string podatek3)
        {
            if (podatek1 == String.Empty || podatek2 == String.Empty || podatek3 == String.Empty)
            {
                throw new Exception("Please insert all data");
            }
        }
        public void PreveriCeJePrazno2(string podatek1, string podatek2, string podatek3)
        {
            if (podatek1 == String.Empty || podatek2 == String.Empty || podatek3 == String.Empty)
            {
                throw new Exception("You cant save data that has not been calculated yet");
            }
        }

        public void PoglejDatum(string zacDat, string konDat)
        {
            DateTime zacetniDatum = DateTime.Parse(zacDat);
            DateTime koncniDatum = DateTime.Parse(konDat);
            
            int rezultat = DateTime.Compare(zacetniDatum, koncniDatum);

            if(rezultat > 0)
            {
                throw new Exception("End date is earlier than starting date");
            }
            else if(rezultat == 0)
            {
                throw new Exception("Start and end date are identical");
            }
        }
        public int preveriKupon(int stkuponov)
        {
            if (stkuponov != 0 && stkuponov != 1 && stkuponov != 2 && stkuponov != 4 && stkuponov != 12)
            {
                NepravilenKuponException napakaKupon = new NepravilenKuponException();
                throw napakaKupon;
            }
            else return stkuponov;
        }
        
        public decimal PreveriObrestnoMero(string obrestnaMera)
        {
            NepravilnaObrestnaMera napakaObrestnaMera = new NepravilnaObrestnaMera();

            string[] nizZnakov = new string[obrestnaMera.Length];
            int i = 0;
            string pomozniZnak;
            decimal convertedObrestnaMera;

            foreach(char znak in obrestnaMera)
            {
                pomozniZnak = Convert.ToString(znak);
                if (pomozniZnak == " ") throw napakaObrestnaMera;
                nizZnakov[i] = pomozniZnak;
                i++;
            }

            if (nizZnakov[obrestnaMera.Length - 1].Equals("%"))
            {
                obrestnaMera = obrestnaMera.Substring(0, obrestnaMera.Length - 1);
                try
                {
                    convertedObrestnaMera = Convert.ToDecimal(obrestnaMera);
                }
                catch
                {
                    throw napakaObrestnaMera;
                }
         
                return Convert.ToDecimal(obrestnaMera);

            }
            else
            throw new Exception("Invalid interest rate. Example: 4%");    
        }

        public decimal preveriNominalo(string nominalaString)
        {
            decimal nominala;
            try
            {
                nominala = (decimal)(Convert.ToDouble(nominalaString));            
            }
            catch(Exception nominalaNapaka)
            {
                throw nominalaNapaka;
            }
            if(nominala == 0)
            {
                throw new Exception("Nominal value cant be 0");
            }
            else
            return nominala;
        }
        public void preveriOznakoNalozbe(string vrstaNalozbe)
        {
            if (vrstaNalozbe == "(select plan)")
            {
                throw new Exception("Please select a plan");
            }
        }

    }
}
