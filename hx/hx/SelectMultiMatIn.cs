using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hx
{
    class SelectMultiMatIn
    {
        public  Boolean getMultiMatIn (string PurId)
        {
           
            string sql ="select id from T_matin where purid ='"+ PurId + "'";
            databaseexe databaseexe = new databaseexe();
            string  result =  databaseexe.getTopselect(sql, "id");
            if (result==null)
            {
                return false;
                
            }
            else {
                return true;
            }


        }


    }
}
