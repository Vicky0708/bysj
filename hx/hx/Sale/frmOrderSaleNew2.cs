using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json.Linq;

namespace hx
{
    public partial   class frmOrderSaleNew2 : Form
    {
        string orderid;
        public frmOrderSaleNew2(string id)
        {
            InitializeComponent();
            orderid = id;

        }
        public static frmOrderSaleNew2 FrmOrderSaleNew2 = null;
        
        public frmOrderSaleNew2()
        {
            InitializeComponent();
            FrmOrderSaleNew2 = this;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxInDate_TextChanged(object sender, EventArgs e)
        {
            
            //toolStripStatusLabelName.Text = dataValue.StaffName.ToString();
        }

        private void frmOrderSaleNew2_Load(object sender, EventArgs e)
        {
            string sql1 = "select Status from  T_ordersale where Orderid='" + textBoxOrderid.Text.Trim() + "'";

            DataTable de =
                dbexe.getdataset(sql1, "T_ordersale").Tables[0];
            for (int i = 0; i < de.Rows.Count; i++)
            {
                DataRow dc = de.Rows[i];
                textBoxStatus.Text = dc["Status"].ToString();

            }
            textBoxInDate.Text = DateTime.Now.ToShortDateString();
            textBoxOderperson.Text = dataValue.StaffName.ToString();
            LoadRecord();
            dgload(orderid);
            

        }
        public void dgload(string orderid)
        {
            ProductdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql= "select  id as 专案编码,productNAME as 品名,productType as 箱式,materialname as 纸板材料,PLength as 长,Pwide as 宽,Pheight as 高,unit as 单位, Price as 单价 ,orderquantity as 订购数量 from T_allsale where orderid ='" + orderid + "'";

           ProductdataGridView1.DataSource =
             
            dbexe.getdataset(sql, "T_allsale").Tables[0];
            ProductdataGridView1.EnableHeadersVisualStyles = false;
            ProductdataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            ProductdataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            ProductdataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void buttonAddCus_Click(object sender, EventArgs e)
        {
            frmClientAdd frmsub = new frmClientAdd();
            frmsub.Show();
            frmsub.buttonSave.Enabled = false;
            frmsub.buttonSaveNew.Enabled = true;
        }
        databaseexe dbexe = new databaseexe();
        private void LoadRecord()
        {
           
            string sql = "select CusId as 客户编码,CusShort as 客户简称 from T_Customer";
            DataTable db = dbexe.getdataset(sql, "T_Customer").Tables[0];
            comboBoxMultiColumnsClientid.DataSource = db;
            

            /*for (int i = 0; i < db.Rows.Count; i++)
            {

                DataRow da = db.Rows[i];
                comboBoxMultiColumnsClientid.Items.Add(da["Cusid"]);

            }*/

            if (db.Rows.Count > 0)
            {
                comboBoxMultiColumnsClientid.SelectedIndex = -1;

            }

        }

        private void buttonFix_Click(object sender, EventArgs e)
        {
            string Cusid = comboBoxMultiColumnsClientid.Text.ToString();
            string OrderId = textBoxOrderid.Text.ToString();
            frmOrderFix2 frmsub = new frmOrderFix2(Cusid,OrderId);
            frmsub.Show();
        }

        private void comboBoxMultiColumnsClientid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxMultiColumnsClientid_TextChanged(object sender, EventArgs e)
        {
            string sql="select cusShort from T_Customer where cusid='"+comboBoxMultiColumnsClientid.Text.Trim()+"'";
            databaseexe databaseexe = new databaseexe();
            string da=databaseexe.getTopselect(sql, "Cusshort");
            textBoxClientName.Text = da;
            
            

        }
       

        private void ProductdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {

            if (comboBoxMultiColumnsClientid.Text == "")
            {
                MessageBox.Show("请先选择客户！");
            }
            else
            {
                string cusid = comboBoxMultiColumnsClientid.Text.Trim();
                OrderGenerator orderGenerator = new OrderGenerator();
                JObject jsonObject = new JObject();
                jsonObject = JObject.Parse(orderGenerator.orderGenerator(cusid));
                //Boxid=

                textBoxOrderid.Text = jsonObject.GetValue("orderid").ToString();
                string orderid = jsonObject.GetValue("orderid").ToString();
                dataValue.saleid = orderid;
                string number = jsonObject.GetValue("number").ToString();
                dataValue.salenumber = number;
                dataValue.indate = textBoxInDate.Text.ToString();
                dataValue.deliverytime = DeliveryTimePicker2.Value.ToShortDateString();
                dataValue.orderdate = OrderdateTimePicker1.Value.ToShortDateString();
                dataValue.orderPerson = textBoxOderperson.Text.Trim();
                string sql = "insert into T_allsale (number,orderid,cusid,indate,orderDate,deliverytime)values('" + number + "','" + orderid + "','"+cusid+ "','"+textBoxInDate.Text.Trim()+ "','"+OrderdateTimePicker1.Value.ToShortDateString()+ "','"+DeliveryTimePicker2.Value.ToShortDateString()+"')";
                databaseexe databaseexe = new databaseexe();   
                //dbexe.sqlcmd(sql);
                //MessageBox.Show("数据添加成功!");
            }
            
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string OrderId = textBoxOrderid.Text.ToString();
            string CheckTime = DateTime.Now.ToShortDateString();
            string CheckPerson = dataValue.StaffName;
            string sql= "update T_OrderSale set status ='已审核',checktime ='"+CheckTime+"',checkperson='"+CheckPerson+"' where orderid='" + OrderId + "'";
            dbexe.sqlcmd(sql);
          
            string statusQuery = "select distinct(status) from T_ordersale where orderid='" + OrderId+ "'";
            databaseexe databaseexe = new databaseexe();
            string da = databaseexe.getTopselect(statusQuery, "status");
            textBoxStatus.Text = da;
            string CheckDateQuery = "select distinct(checktime) from T_ordersale where orderid='" + OrderId + "'";
            string dc = databaseexe.getTopselect(CheckDateQuery, "checktime");
            textBoxCheckDate.Text = dc;
            string checkPersonQuery = "select distinct(checkperson) from T_ordersale where orderid='" + OrderId + "'";
            string db = databaseexe.getTopselect(checkPersonQuery, "checkperson");
            textBoxCheckPerson.Text = db;


        }

        private void buttonModify_Click(object sender, EventArgs e)
        {

        }
    }
}
