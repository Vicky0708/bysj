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
    public partial class frmProductIn3 : Form
    {
        public frmProductIn3()
        {
            InitializeComponent();
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            frmProInAdd3 frmsub = new frmProInAdd3();
            frmsub.Show();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        databaseexe dbexe = new databaseexe();
        private void frmProductIn3_Load(object sender, EventArgs e)
        {
            DingdandataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select proinId as 入仓单号,zhuananid as 专案编号,CusShort as 客户,productName as 品名,producttYPE as 箱式,plength as 长,pwide as 宽,pheight as 高,unit as 单位,proinquantity as 入仓数量,proindate as 入仓日期 from T_proin where proinid is not null";
            DingdandataGridView1.DataSource =
            dbexe.getdataset(sql, "T_proin").Tables[0];
            DingdandataGridView1.EnableHeadersVisualStyles = false;
            DingdandataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            DingdandataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            DingdandataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select proinId as 入仓单号,zhuananid as 专案编号,CusShort as 客户,productName as 品名,producttYPE as 箱式,plength as 长,pwide as 宽,pheight as 高,unit as 单位,proinquantity as 入仓数量,proindate as 入仓日期 from T_proin where proinid is not null";
            DingdandataGridView1.DataSource =
            dbexe.getdataset(sql, "T_proin").Tables[0];
        }
    }
}
