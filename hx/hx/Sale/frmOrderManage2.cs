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
    public partial class frmDingdan : Form
    {
        public frmDingdan()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        databaseexe dbexe = new databaseexe();
        private void frmDingdan_Load(object sender, EventArgs e)
        {
            DingdandataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select Cusshort as 客户,orderid AS 订单号 ,id as 专案编号, Productname as 品名, producttype as 箱式,materialname as 纸板名称 ,plength as 长,pwide as 宽,pheight as 高, unit as 单位 from T_alls ";
            DingdandataGridView1.DataSource =
            dbexe.getdataset(sql, "T_salls").Tables[0];
            DingdandataGridView1.EnableHeadersVisualStyles = false;
            DingdandataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            DingdandataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            DingdandataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            frmOrderSaleNew2 frmsub = new frmOrderSaleNew2();
            frmsub.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql1 = "select Cusshort as 客户,orderid AS 订单号 ,id as 专案编号, Productname as 品名, producttype as 箱式,materialname as 纸板名称 ,plength as 长,pwide as 宽,pheight as 高 from T_alls ";
            DingdandataGridView1.DataSource =
            dbexe.getdataset(sql1, "T_alls").Tables[0];
        }

        private void DingdandataGridView1_DoubleClick(object sender, EventArgs e)
        {

            frmOrderDetail2 frmsub = new frmOrderDetail2(DingdandataGridView1.CurrentRow);

            frmsub.Show();
            
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            //string unqiueId=DingdandataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmSaleModify2 frmsub = new frmSaleModify2(DingdandataGridView1.CurrentRow);
            frmsub.Show();
        }

        private void DingdandataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
