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
    public partial class frmSupplierPrice : Form
    {
        public frmSupplierPrice(DataGridViewRow dgvr1)
        {
            InitializeComponent();
            dgvr = dgvr1;
            getValue();


        }

        public DataGridViewRow dgvr;
        string SupId;
        public void getValue()
        {
         SupId= dgvr.Cells[0].Value.ToString();

        }
        public frmSupplierPrice()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSupplierPrice_Load(object sender, EventArgs e)
        {
            
            SupPricedataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql = "select SupShort as 供方简称,MaterialId as 纸板编码, MaterialName as 纸板名称,materialType as 纸板材质,MaterialPrice as 基价 from T_SupplierPrice where SupId like'" + SupId + "'";
            SupPricedataGridView1.DataSource =
            dbexe.getdataset(sql, "T_supplierPrice").Tables[0];
            SupPricedataGridView1.EnableHeadersVisualStyles = false;
            SupPricedataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            SupPricedataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            SupPricedataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        databaseexe dbexe = new databaseexe();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
