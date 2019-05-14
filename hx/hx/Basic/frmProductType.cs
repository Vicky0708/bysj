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
    public partial class frmProductType : Form
    {
        public frmProductType()
        {
            InitializeComponent();
        }

        private void TypedataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        databaseexe dbexe = new databaseexe();
        private void frmProductType_Load(object sender, EventArgs e)
        {
            TypedataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
            string sql = "select Id as 编码,TypeName as 种类名称 from T_productType ";
            TypedataGridView1.DataSource =
            dbexe.getdataset(sql, "T_productType").Tables[0];
            TypedataGridView1.EnableHeadersVisualStyles = false;
            TypedataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            TypedataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            TypedataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            frmProductTypeAdd frmProductTypeAdd = new frmProductTypeAdd();
            frmProductTypeAdd.Show();
            frmProductTypeAdd.buttonSave.Enabled = false;
            frmProductTypeAdd.buttonSaveNew.Enabled = true;
        }

        private void TypedataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
            frmProductTypeAdd frmsub = new frmProductTypeAdd(TypedataGridView1.CurrentRow);
            frmsub.Show();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            frmProductTypeAdd frmsub = new frmProductTypeAdd(TypedataGridView1.CurrentRow);

            frmsub.Show();
            frmsub.buttonSave.Enabled = true;
            frmsub.buttonSaveNew.Enabled = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select Id as 编码,TypeName as 种类名称 from T_productType ";
            TypedataGridView1.DataSource =
            dbexe.getdataset(sql, "T_ProductType").Tables[0];
        }
    }
}
