using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hx
{
    class Connstr
    {
        public Connstr()
        { }
        public SqlConnection getcon()
        {
            string sqlcon = "Data Source=(local); Database=jxsysDB; Trusted_Connection=SSPI"; //Windows身份验证
                                                                                              //也可以采用密码验证：Uid=sa;PWD=sa 	
            SqlConnection mycon = new SqlConnection(sqlcon);
            mycon.Open();
            return mycon;
        }

    }
}
