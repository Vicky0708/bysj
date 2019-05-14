using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace hx
{
    class databaseexe
    {
        public databaseexe()
        { }
        Connstr connstr = new Connstr();
        //执行sql
        public void sqlcmd(string sqlstr)
        {
            SqlConnection conn = connstr.getcon();
            SqlCommand scmd = new SqlCommand(sqlstr, conn);
            scmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataSet getdataset(string sql, string table)
        {
            SqlConnection conn = connstr.getcon();
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, table);
            conn.Close();
            return ds;

        }
        public string getvalue(string sql)
        {
            string ans;
            SqlConnection conn = connstr.getcon();
            SqlCommand scmd = new SqlCommand(sql, conn);
            ans = scmd.ExecuteScalar().ToString();
            return ans;
        }
        public string getTopName(string sql)
        {
            DataSet ds = new DataSet();
            string jobname = null;
            try
            {
                SqlConnection conn = connstr.getcon();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
               
                sda.Fill(ds, "ds");
                conn.Close();
                if (ds.Tables[0].Rows.Count > 0) {
                    jobname = ds.Tables[0].Rows[0]["jobName"].ToString();
                }
            }
            catch (System.Data.SqlClient.SqlException ex) {
                throw new Exception(ex.Message);
            }

            return jobname;
        }
        public string getTopid(string sql)
        {
            DataSet ds = new DataSet();
            string id = null;
            try
            {
                SqlConnection conn = connstr.getcon();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

                sda.Fill(ds, "ds");
                conn.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    id = ds.Tables[0].Rows[0]["id"].ToString();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return id;
        }

        public string getTopselect(string sql,string columname)
        {
            DataSet ds = new DataSet();//实例化一个数据集
            string id = null;
            try
            {
                /*string BomidQuery = "select bomid from T_pur where zhuananid='" + ZhuanAnid + "'";
                string bomid = databaseexe.getTopselect(BomidQuery, "bomid");*/
                SqlConnection conn = connstr.getcon();//数据库建立连接
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);//实例化一个sda 用来接收执行的sql语句

                sda.Fill(ds, "ds");//把sda里的数据往数据集ds里倒
                conn.Close();
                if (ds.Tables[0].Rows.Count > 0)//如果表里有数据
                {
                    id = ds.Tables[0].Rows[0][columname].ToString();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return id;
        }
        public string[] getMultiData(string sql, string columname)
        {
            DataSet ds = new DataSet();
            string id = null;
            string[] arr;
            try
            {
                SqlConnection conn = connstr.getcon();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                
                sda.Fill(ds, "ds");
                conn.Close();
                 arr = new string[ds.Tables[0].Rows.Count];
                if (ds.Tables[0].Rows.Count > 0)
                {
                   
                    for (int i = 0;i< ds.Tables[0].Rows.Count; i++) {
                        string temp = ds.Tables[0].Rows[i][columname].ToString();
                        arr[i] = temp;
                  
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return arr;
        }
    }
}
