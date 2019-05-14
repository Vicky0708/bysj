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
    public partial class frmManuManage3 : Form
    {
        public frmManuManage3()
        {
            InitializeComponent();
        }

        private void textBoxDeliveryDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CheckdateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OrderdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ProductdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCheckPerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMemo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMultiColumnsClientid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxClientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOderperson_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOrderid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {

        }

        private void buttonFix_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {

        }

        private void ManudataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void frmManuOrder3_Load(object sender, EventArgs e)
        {
            ManudataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select ManuId as 生产单号,ZhuanAnid as 专案编号,CusShort as 客户,productName as 品名,productType as 箱式,plength as 长,pwide as 宽,pheight as 高,unit as 单位,orderQuantity as 订单数量,materialName as 纸板名称,BomSize as 纸板尺寸,allmaterialQuantity as 张数 from T_manus where id is not null";
            ManudataGridView1.DataSource =
            dbexe.getdataset(sql, "T_manus").Tables[0];
            ManudataGridView1.EnableHeadersVisualStyles = false;
            ManudataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            ManudataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            ManudataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        databaseexe dbexe = new databaseexe();

        private void buttonReturn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveNew_Click_1(object sender, EventArgs e)
        {
            frmManuOrderAdd3 frmsub = new frmManuOrderAdd3();
            frmsub.Show();
             
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select ManuId as 生产单号,ZhuanAnid as 专案编号,CusShort as 客户,productName as 品名,productType as 箱式,plength as 长,pwide as 宽,pheight as 高,unit as 单位,orderQuantity as 订单数量,materialName as 纸板名称,BomSize as 纸板尺寸,allmaterialQuantity as 张数 from T_manus where id is not null";
            ManudataGridView1.DataSource =
            dbexe.getdataset(sql, "T_manus").Tables[0];
        }
        /* public void dgload(string orderid)
{
string sql = "select  id as 专案编码,productNAME as 品名,productType as 箱式,materialname as 纸板材料,PLength as 长,Pwide as 宽,Pheight as 高,unit as 单位, Price as 单价 ,quantity as 订购数量  from T_allsale where orderid ='" + orderid + "'";

ManudataGridView1.DataSource =

dbexe.getdataset(sql, "T_allsale").Tables[0];


}*/
    }
}
