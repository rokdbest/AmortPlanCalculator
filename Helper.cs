using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace amort_nacrt_2
{
    public static class Helper
    {
        public static string ConnectionVal(string name)
        {          
            //tim correy yt tutorial - helper (vzame name od app config database
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
