using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hx
{
    public partial class frmOrderFix2 : Form
    {
        string Cid,Oid;
        public frmOrderFix2(string id,string id2)
        {
            InitializeComponent();
            Cid = id;
            Oid = id2;
            
        }
        public frmOrderFix2()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        databaseexe dbexe = new databaseexe();
        private void frmOrderFix2_Load(object sender, EventArgs e)
        {
            try
            {
                ProductdataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                string sql = "select id as 编码,productName as 品名,productType as 箱式,PLength as 长,Pwide as 宽,Pheight as 高,unit as 单位, Price as 单价  from T_fixpro where fatherid is null and CusId ='" +Cid+ "'";
                ProductdataGridView2.DataSource =
               dbexe.getdataset(sql, "T_ALLproduct").Tables[0];
                ProductdataGridView2.EnableHeadersVisualStyles = false;
                ProductdataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
                ProductdataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
                ProductdataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Connstr connstr = new Connstr();
                databaseexe dbexe = new databaseexe();
                string ProName = textBoxName.Text.Trim();
                string sql = "select id as 编码,productName as 品名,productType as 箱式,PLength as 长,Pwide as 宽,Pheight as 高,unit as 单位, Price as 单价  from T_fixpro where fatherid is null and CusId ='" + Cid + "'and productname like'%" + ProName + "%'";
                //string sql = "select CusID as 客户编码,CusShort as 客户简称, CusName as 客户全称, CusTelephone as 电话,CusFax as 传真,CusAdress as 地址,CusPerson as 联系人 from T_customer where CusId like'%" + CusId + "%'";
                DataTable dt =
                dbexe.getdataset(sql, "T_T_fixpro").Tables[0];
               ProductdataGridView2.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("没有符合条件的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //buttonModify.Enabled = false;
                    textBoxName.Clear();
                }
                else
                {
                    MessageBox.Show("查询到：" + dt.Rows.Count + " 条记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //buttonModify.Enabled = true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string saleid = dataValue.saleid;
            try
            {
                if (textBoxNumber.Text == "")
                {
                    MessageBox.Show("未填写数量！");
                    return;

                }
                else

                {
                   /* string cusid = Cid;
                    OrderGenerator orderGenerator = new OrderGenerator();
                    JObject jsonObject = new JObject();
                    jsonObject = JObject.Parse(orderGenerator.orderGenerator(cusid));
                    //Boxid=

                    /*textBoxOrderid.Text = jsonObject.GetValue("orderid").ToString();
                    string orderid = jsonObject.GetValue("orderid").ToString();
                    string number = jsonObject.GetValue("number").ToString();
                    string sql = "insert into T_allsale (number,orderid,cusid)values('" + number + "','" + orderid + "','" + cusid + "')";
                    databaseexe databaseexe = new databaseexe();*/




                    string boxid = ProductdataGridView2.CurrentRow.Cells[0].Value.ToString();
                    string idQuery = "select id  from T_fixpro where fatherid='"+ boxid + "'or id ='"+ boxid + "'order by id asc";
                    databaseexe databaseexe = new databaseexe();
                    string[] arr = databaseexe.getMultiData(idQuery, "id");
                    for (int i = 0; i < arr.Length; i++) {
                        string id;
                        id = arr[i];
                         string sql = "insert into T_ordersale (number,orderid ,proid,cusid,quantity,indate,orderdate,deliverytime,orderperson) values ('" +dataValue.salenumber+"','" + dataValue.saleid + "','" + id+ "','"+Cid+ "','" + textBoxNumber.Text.Trim() + "','"+dataValue.indate+ "','"+dataValue.orderdate+ "','"+dataValue.deliverytime+ "','"+dataValue.orderPerson+"')";
                        dbexe.sqlcmd(sql);
                    }

                    string biliQuery = "select quantity from T_fixpro where id ='"+ boxid + "' or fatherid = '"+ boxid + "'  order by id  asc";

                    string[] bili = databaseexe.getMultiData(biliQuery, "quantity");
                    string shuliang = textBoxNumber.Text.ToString().Trim();
                    
                    for(int j = 1;j<bili.Length ;j++)
                    {    string tempid =  arr[j];
                        string tempbili = bili[j];
                        int tempnumber = int.Parse(tempbili) * int.Parse(shuliang);
                        string sql  = "update t_ordersale set quantity='" + tempnumber + "' where proid = '"+ tempid + "'";
                        databaseexe.sqlcmd(sql);
                    }


                    MessageBox.Show("数据添加成功!");
                    /*teacherdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    string sql1 = "select teacherId as 教师编号,teacherName as 教师姓名,tage as 年龄,Tdepartement as 所属学院 from teacher";
                    teacherdataGridView1.DataSource =
                    dbexe.getdataset(sql1, "teacher").Tables[0];*/
                    string Orderid = dataValue.saleid;
                    frmOrderSaleNew2 frmsub = new frmOrderSaleNew2(Orderid);
                frmOrderSaleNew2.FrmOrderSaleNew2.dgload(Orderid);
                this.Close();
                }

                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          


        }
    }
}
