using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace hx
{
    class ManuGenarator
    {
        public string manuGenerator(string shengchandan)
        {
            string ManuID = null;


            string prefix = "SCD";
            ManuID = prefix + shengchandan;
            return ManuID;



        }
    }
}
