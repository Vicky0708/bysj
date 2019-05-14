using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hx
{
    class AutoCount
    {
        public string priceCount(string length, string wide, string height)
        {
            // (DDL+DDW+7)*(DDW+DDH+6)*JJ/10000
            string total = (((float.Parse(length) + float.Parse(wide) + 7.0) * (float.Parse(wide) + float.Parse(height) + 6.0) * 7.2 )/ 10000).ToString();
            return total;
        }
        public string MaterialCount(string orderquantity, string unitquantity)
        {
            string materialTotal = (int.Parse(orderquantity) * int.Parse(unitquantity)).ToString();
            return materialTotal;


            
        }
    }
}
