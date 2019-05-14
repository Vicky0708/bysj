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
    public partial class frmDeliveryManage5 : Form
    {
        public frmDeliveryManage5()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            frmDeliveryAdd5 frmsub = new frmDeliveryAdd5();
            frmsub.Show();
        }
        databaseexe dbexe = new databaseexe();
        private void frmDeliveryManage5_Load(object sender, EventArgs e)
        {
            DeliverydataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select DeliveryID as 送货单号,deliveryindate AS 出货日期 ,zhuananid as 专案编号, Productname as 品名, producttype as 箱式,materialname as 纸板名称 ,plength as 长,pwide as 宽,pheight as 高, unit as 单位,deliveryoutquantity as 出货数量,carperson as 车号 from T_DelOut where deliveryid is not null ";
            DeliverydataGridView1.DataSource =
            dbexe.getdataset(sql, "T_DelOut").Tables[0];
            DeliverydataGridView1.EnableHeadersVisualStyles = false;
            DeliverydataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            DeliverydataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            DeliverydataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select DeliveryID as 送货单号,deliveryindate AS 出货日期 ,zhuananid as 专案编号, Productname as 品名, producttype as 箱式,materialname as 纸板名称 ,plength as 长,pwide as 宽,pheight as 高, unit as 单位,deliveryoutquantity as 出货数量,carperson as 车号 from T_DelOut where deliveryid is not null ";
            DeliverydataGridView1.DataSource =
            dbexe.getdataset(sql, "T_DelOut").Tables[0];
        }
    }
}
