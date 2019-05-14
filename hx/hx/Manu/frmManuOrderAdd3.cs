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
    public partial class frmManuOrderAdd3 : Form
    {


        string Manuorderid,ManuId;
        public frmManuOrderAdd3(string id)
        {
            InitializeComponent();
            Manuorderid = id;

        }
        public frmManuOrderAdd3()
        {
            InitializeComponent();
            FrmManuOrderAdd3 = this;
        }

        public static frmManuOrderAdd3 FrmManuOrderAdd3 = null;

  

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            frmSaleSearch3 frmsub = new frmSaleSearch3();
            frmsub.Owner = this;
            frmsub.Show();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        databaseexe dbexe = new databaseexe();

        private void frmManuOrderAdd3_Load(object sender, EventArgs e)
        {
            textBoxManuPerson.Text = dataValue.StaffName.ToString();
            
            dgload(Manuorderid,ManuId);
            
        }
        public void dgload(string Manuorderid,string ManuId)
        {
            ManudataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql = "select zhuananId as 专案编码, Productname as 品名, producttype as 箱式," +
                "materialname as 纸板名称 ,plength as 长,pwide as 宽,pheight as 高,unit as 单位,Bomsize as 用料," +
                "allMaterialQuantity as 张数 from T_manus where orderid= '"+Manuorderid+"'";           
            ManudataGridView1.DataSource =
             dbexe.getdataset(sql, "T_manus").Tables[0];
            ManudataGridView1.EnableHeadersVisualStyles = false;
            ManudataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            ManudataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            ManudataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            databaseexe databaseexe = new databaseexe();
            textBoxSaleID.Text = Manuorderid;
            textBoxManuId.Text = ManuId;
            string CusidQuery = "select distinct(Cusid) from T_allsale where orderid='" +Manuorderid + "'";
            string da = databaseexe.getTopselect(CusidQuery, "Cusid");
            textBoxCusid.Text = da;
            string CusShortQuery = "select CusShort from T_Customer where Cusid='" + da + "'";
            textBoxCusshort.Text = databaseexe.getTopselect(CusShortQuery, "CusShort");
            string OrderDateQuery = "select distinct(orderDate) from T_allSale where Orderid='" + Manuorderid + "'";
            textBoxOrderdate.Text = databaseexe.getTopselect(OrderDateQuery, "OrderDate");
            string DeliveryDateQuery = "select distinct(Deliverytime) from T_allSale where orderid='" + Manuorderid + "'";
            textBoxDeliveryDate.Text = databaseexe.getTopselect(DeliveryDateQuery, "deliverytime");
        }

        private void textBoxManuPerson_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
