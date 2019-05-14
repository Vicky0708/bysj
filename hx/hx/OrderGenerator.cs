using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace hx
{
    class OrderGenerator
    {
        public string orderGenerator(string cusid)
        {
            string orderid = null;
           
             string sql = " select top 1 * from T_allsale where cusid ='" + cusid + "' order by number desc";
            databaseexe databaseexe = new databaseexe();
            int number;
            string judge = databaseexe.getTopselect(sql, "number");
            if (judge == null) {
                number = 0;
            }
            else {
                number = int.Parse(judge);
            }
            
            number = number + 1;
             orderid = number.ToString();
            for (int i = 0; i <(8- number.ToString().Length); i++) {

                orderid = "0" + orderid;
            }
            orderid = cusid + orderid;

            JObject jsonObject = new JObject();
            jsonObject["number"] = number;
            jsonObject["orderid"] = orderid;
            var json = jsonObject.ToString();
            return json;
        }
    }
}
