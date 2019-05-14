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
    public partial class frmMatStock5 : Form
    {
        public frmMatStock5()
        {
            InitializeComponent();
        }
        databaseexe dbexe = new databaseexe();
        private void frmMatStock5_Load(object sender, EventArgs e)
        {
            MatStockdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select Bomid as 编号,BomName AS 物料名称 ,BomSize as 物料规格,Stock as 当前库存 from T_bom ";
            MatStockdataGridView1.DataSource =
            dbexe.getdataset(sql, "T_matStock").Tables[0];
            MatStockdataGridView1.EnableHeadersVisualStyles = false;
            MatStockdataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            MatStockdataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            MatStockdataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            try
            {
                
                string MatQuery = textBoxMatStock.Text.ToString();
                string bomid = MatStockdataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "update T_Bom set Stock='" + MatQuery + "'where bomid= '" + bomid + "'";
                dbexe.sqlcmd(sql);
                //MessageBox.Show("当前库存修改成功!");
                string sql1 = "select Bomid as 编号,BomName AS 物料名称,BomSize as 物料规格,Stock as 当前库存 from T_bom ";
                MatStockdataGridView1.DataSource =
                dbexe.getdataset(sql1, "T_Bom").Tables[0];
                textBoxMatStock.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           // FixProductGridView1.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
