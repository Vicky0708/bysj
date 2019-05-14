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
    public partial class frmSaleModify2 : Form
    {
        
        public frmSaleModify2(DataGridViewRow dgvr1)
        {
            InitializeComponent();
            dgvr = dgvr1;
            getValue();



        }
        
        public DataGridViewRow dgvr;
        public void getValue()
        {
            textBoxOrderid.Text = dgvr.Cells[1].Value.ToString();
            //string UniqueId = dgvr.Cells[2].Value.ToString();
            /*textBoxProductName.Text = dgvr.Cells[3].Value.ToString();
            textBoxTypeNAME.Text = dgvr.Cells[4].Value.ToString();
            textBoxMaterialName.Text = dgvr.Cells[5].Value.ToString();
            textBoxLength.Text = dgvr.Cells[6].Value.ToString();
            textBoxWide.Text = dgvr.Cells[7].Value.ToString();
            textBoxHeight.Text = dgvr.Cells[8].Value.ToString();*/
            


        }

        public frmSaleModify2()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            /*string MaterialId = textBoxID.Text.Trim();
            string MaterialName = textBoxName.Text.Trim();
            string MaterialType = textBoxType.Text.Trim();
            string sql = "update T_Material set materialName='" + MaterialName + "',materialType='" + MaterialType + "'where materialId = '" + MaterialId + "'";
            dbexe.sqlcmd(sql);
            MessageBox.Show("数据保存成功!");*/
        }
        databaseexe databaseexe = new databaseexe();
        databaseexe dbexe = new databaseexe();
        private void frmSaleModify2_Load(object sender, EventArgs e)
        {
            string deliveryDateQuery = "select distinct(deliverytime ) from T_allsale where orderid ='" + textBoxOrderid.Text.Trim() + "'";
            DeliveryTimePicker2.Text = databaseexe.getTopselect(deliveryDateQuery, "deliverytime");
            string OrderDateQuery = "select distinct(orderdate ) from T_allsale where orderid ='" + textBoxOrderid.Text.Trim() + "'";
            OrderdateTimePicker1.Text = databaseexe.getTopselect(OrderDateQuery, "orderdate");
            string InDateQuery = "select distinct(indate ) from T_allsale where orderid ='" + textBoxOrderid.Text.Trim() + "'";
            textBoxInDate.Text = databaseexe.getTopselect(InDateQuery, "indate");
            string OrderpersonQuery = "select distinct(orderperson ) from T_allsale where orderid ='" + textBoxOrderid.Text.Trim() + "'";
            textBoxOderperson.Text = databaseexe.getTopselect(OrderpersonQuery, "orderperson");
            string CusidQuery = "select distinct(Cusid ) from T_allsale where orderid ='" + textBoxOrderid.Text.Trim() + "'";
            textBoxClientID.Text = databaseexe.getTopselect(CusidQuery, "cusid");
            string CusShortQuery = "select distinct(Cusshort ) from T_Customer where cusid ='" + textBoxClientID.Text.Trim() + "'";
            textBoxClientName.Text = databaseexe.getTopselect(CusShortQuery, "cusShort");
            string StatusQuery= "select distinct(status ) from T_allsale where orderid ='" + textBoxOrderid.Text.Trim() + "'";
            textBoxStatus.Text = databaseexe.getTopselect(StatusQuery,"status");
            SaledataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string checkQuery= "select distinct(checkTime) from T_allsale where orderid ='" + textBoxOrderid.Text.Trim() + "'";
            textBoxCheckDate.Text = databaseexe.getTopselect(checkQuery, "checktime");
            string checkPersonQuery = "select distinct(checkperson) from T_ordersale where orderid='" + textBoxOrderid.Text.Trim()+ "'";
            string db = databaseexe.getTopselect(checkPersonQuery, "checkperson");
            textBoxCheckPerson.Text = db;


            string sql = "select  id as 专案编码,productNAME as 品名,productType as 箱式,materialname as 纸板材料,PLength as 长,Pwide as 宽,Pheight as 高,unit as 单位, Price as 单价 ,orderquantity as 订购数量 from T_allsale where orderid ='" + textBoxOrderid.Text.Trim() + "'";
            SaledataGridView1.DataSource =
            dbexe.getdataset(sql, "T_allsale").Tables[0];
            SaledataGridView1.EnableHeadersVisualStyles = false;
            SaledataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            SaledataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            SaledataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void buttonFix_Click(object sender, EventArgs e)
        {
            string Cusid = textBoxClientID.Text.ToString();
            string OrderId = textBoxOrderid.Text.ToString();
            frmOrderFix2 frmsub = new frmOrderFix2(Cusid, OrderId);
            frmsub.Show();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string OrderId = textBoxOrderid.Text.ToString();
            string CheckTime = DateTime.Now.ToShortDateString();
            string checkperson = dataValue.StaffName;
            string sql = "update T_OrderSale set status ='已审核',checktime ='" + CheckTime + "',checkperson='"+checkperson+"' where orderid='" + OrderId + "'";
            dbexe.sqlcmd(sql);
            string statusQuery = "select distinct(status) from T_ordersale where orderid='" + OrderId + "'";
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
    }
}
