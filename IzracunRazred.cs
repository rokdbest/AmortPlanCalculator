using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amort_nacrt_2
{
    class IzracunRazred
    {
       public decimal IzplaciloObresti(decimal NovaGlavnica, decimal ObrMera)
        {
            ObrMera = ObrMera * 0.01M;
            decimal izplaciloObresti = NovaGlavnica * ObrMera;
            return izplaciloObresti;
        }

        public decimal ZnizanjeGlavnice(decimal FiksniObrok, decimal IzplaciloObresti)
        {
            decimal ZnizanaGlavnica = FiksniObrok - IzplaciloObresti;
            return ZnizanaGlavnica;
        }

        public decimal IzracunNoveGlavnice(decimal StaraGlavnica, decimal ZnizanaGlavnica)
        {
            decimal NovaGlavnica = StaraGlavnica - ZnizanaGlavnica;
            return NovaGlavnica;
        }

        public decimal Pmt(decimal nominala, int steviloVsehPlacil, decimal obrestnaMera)
        {
            obrestnaMera = obrestnaMera / 100;
            decimal pmt = (1 - (1 / (decimal)Math.Pow((double)(1 + obrestnaMera), steviloVsehPlacil))) / obrestnaMera;
            pmt = (decimal)nominala / pmt;

            return pmt;
        }

        public List<string> SeznamDatumov(string zacetniDatum, string koncniDatum, int kup)
        {
            var seznamDatumov = new List<string>();
            seznamDatumov.Add(zacetniDatum); //prvi datum dodan na zacetku zaradi loopa

            //var stevecDatumovObrokov = PrviObrok(DateTime.Parse(zacetniDatum));

            var stevecDatumovObrokov = DateTime.Parse(zacetniDatum);
            var koncDat = DateTime.Parse(koncniDatum);

            int steviloObrokovNaLeto = 0; // pogleda koliko kuponov na leto

            switch (kup)
            {
                case 12: steviloObrokovNaLeto = 1; break;
                case 4: steviloObrokovNaLeto = 3; break;
                case 2: steviloObrokovNaLeto = 6; break;
                case 1: steviloObrokovNaLeto = 12; break;
            }
            

            do
            {
                stevecDatumovObrokov = stevecDatumovObrokov.AddMonths(steviloObrokovNaLeto); // doda mesece
                seznamDatumov.Add(Convert.ToString(stevecDatumovObrokov.ToString("dd-MM-yyyy"))); //doda v seznam

                if(stevecDatumovObrokov == koncDat)
                {
                    break;
                }

                if (stevecDatumovObrokov.AddMonths(steviloObrokovNaLeto) > koncDat)
                {
                    break;
                }

            } while (stevecDatumovObrokov != koncDat); //cause we can

            return seznamDatumov;
        }

        //iz zacetnega datuma dobim prvi obrok naslednji mesec  - trenutno ne uporabljam
        public static DateTime PrviObrok(DateTime zacDatum)    
        {
            var prviObrok = zacDatum;

            prviObrok.AddMonths(1);


            while (prviObrok.Day != 10)
            {
                if (prviObrok.Day > 10)
                {
                    prviObrok.AddDays(-1);
                }

                if (prviObrok.Day < 10)
                {
                    prviObrok.AddDays(1);
                }
            }

            Console.WriteLine(prviObrok);


            return prviObrok;
        }
    }      
}
