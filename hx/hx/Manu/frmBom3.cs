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
    public partial class frmBom3 : Form
    {
        public frmBom3()
        {
            InitializeComponent();
        }
        databaseexe dbexe = new databaseexe();
        private void frmBom3_Load(object sender, EventArgs e)
        {
            BomGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select id as 产品编码,productname as 产品名称,plength as 长,pwide as 宽,pheight as 高 from T_BomAll ";
            BomGridView1.DataSource =
            dbexe.getdataset(sql, "T_bomall").Tables[0];
            BomGridView1.EnableHeadersVisualStyles = false;
            BomGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            BomGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            BomGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            dataValue.Bomid= BomGridView1.CurrentRow.Cells[0].Value.ToString();
            dataValue.Bomlength = BomGridView1.CurrentRow.Cells[2].Value.ToString();
            dataValue.BomWide = BomGridView1.CurrentRow.Cells[3].Value.ToString();
            dataValue.Bomheight = BomGridView1.CurrentRow.Cells[4].Value.ToString();

            frmBomAdd3 frmsub = new frmBomAdd3();
            frmsub.Show();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            
        }
    }
}
