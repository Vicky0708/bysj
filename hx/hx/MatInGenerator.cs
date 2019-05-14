using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hx
{
    class MatInGenerator
    {
        public string MatinGenerator()      
    {
            string sql = "select top 1 matinId from t_MaterialIn order by id desc";
            databaseexe databaseexe = new databaseexe();
            string lastid = databaseexe.getTopselect(sql, "matinid");
            int result = int.Parse(lastid) + 1;

            return result.ToString();
     }
        

    }
}
