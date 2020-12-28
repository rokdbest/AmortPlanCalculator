using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amort_nacrt_2
{
    public class NepravilenKuponException : Exception
    {
        public override string Message
        {
            get
            {
                return "Kupon mora imeti vrednost 0,1,2,4 ali 12";
            }
        }
    }

    public class NepravilnaObrestnaMera : Exception
    {
        public override string Message
        {
            get
            {
                return "Vpis obrestne mere je nepravilen";
            }
        }
    }

    public class NepravilenDatum : Exception
    { 
        public override string Message
        {
            get
            {
                return "Vpis datuma je nepravilen";
            }
        }
    }
    class Izjeme
    {
    }
}
