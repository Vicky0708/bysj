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
    public partial class frmProStock5 : Form
    {
        public frmProStock5()
        {
            InitializeComponent();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            try
            {

                string ProQuery = textBoxProStock.Text.ToString();
                string pid = ProStockdataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "update T_fixpro set Stock='" + ProQuery + "'where id= '" + pid + "'";
                dbexe.sqlcmd(sql);
                //MessageBox.Show("当前库存修改成功!");
                string sql1 = "select id as 编号,Cusid as 客户,productName AS 品名, plength as 长,pwide as 宽,pheight as 高,unit as 单位,stock as 当前库存 from T_fixpro ";
                ProStockdataGridView1.DataSource =
                dbexe.getdataset(sql1, "T_fixpro").Tables[0];
                textBoxProStock.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        databaseexe dbexe = new databaseexe();
        private void frmProStock5_Load(object sender, EventArgs e)
        {
            ProStockdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select id as 编号,Cusid as 客户,productName AS 品名, plength as 长,pwide as 宽,pheight as 高,unit as 单位,stock as 当前库存 from T_fixpro ";
            ProStockdataGridView1.DataSource =
            dbexe.getdataset(sql, "T_fixpro").Tables[0];
            ProStockdataGridView1.EnableHeadersVisualStyles = false;
            ProStockdataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            ProStockdataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            ProStockdataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
