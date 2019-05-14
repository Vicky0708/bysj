using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hx
{
    class ProInGenerator
    {
        public string proInGenerator()
        {
            string sql = "select top 1 ProinID from t_ProductIn order by id desc";
            databaseexe databaseexe = new databaseexe();
            string lastid = databaseexe.getTopselect(sql, "Proinid");
            int result = int.Parse(lastid) + 1;

            return result.ToString();
        }

    }
}
