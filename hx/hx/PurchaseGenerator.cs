using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hx
{
    class PurchaseGenerator
    {
        public string purchaseGenerator()
        {
            DateTime dt = DateTime.Now;
            //string year = dt.Year.ToString();
            //string month = dt.Month.ToString();
            /*if (month.Length < 2) {
                month = "0" + month;
            }
            string day = dt.Day.ToString();
            if (day.Length < 2)
            {
                day = "0" + day;
            }*/
            string count ="";//声明新生成的采购单号
            string purchaseidQuery = "select top 1 Purchaseid from t_purchaseOrder order by id desc";//查询数据库中最后一个采购序号
            databaseexe databaseexe = new databaseexe();
            string lastid = databaseexe.getTopselect(purchaseidQuery, "Purchaseid");
            string lastidDate = lastid.Substring(0, 8);//截取最后一个采购单号的日期yyyyMMdd
            string lastidSEQ = lastid.Substring(8);//截取最后流水号
            DateTime dateTime = DateTime.ParseExact(lastidDate, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
            int result=CompanyDate(dateTime.ToString(), DateTime.Now.ToShortDateString());//比较今天和最后一个采购单号的时间
            if (result == 2)
            {
                count = "001";
            }
            else {
                int _count = int.Parse(lastidSEQ) + 1;
                for (int i = 0; i < 3-_count.ToString().Length; i++)
                {
                    count = count + "0";
                }
                count = count + _count.ToString();
            }
            string code = DateTime.Now.ToString("yyyyMMdd") + count;//最后组成采购单

            return code;



        }
        public int CompanyDate(string dateStr1, string dateStr2)
        {
            //将日期字符串转换为日期对象
            DateTime t1 = Convert.ToDateTime(dateStr1);
            DateTime t2 = Convert.ToDateTime(dateStr2);
            //通过DateTIme.Compare()进行比较（）
            int compNum = DateTime.Compare(t1, t2);
            int msg = 0;
            //t1> t2
            if (compNum > 0)
            {
                msg = 1;
            }
            //t1= t2
            if (compNum == 0)
            {
                msg = 0;
            }
            //t1< t2
            if (compNum < 0)
            {
                msg = 2;
            }
            return msg;
        }



    }
}
