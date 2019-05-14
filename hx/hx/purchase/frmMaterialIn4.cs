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
    public partial class frmMaterialIn4 : Form
    {
        public frmMaterialIn4()
        {
            InitializeComponent();
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            frmMaterialInOrder4 frmsub = new frmMaterialInOrder4();
            frmsub.Show();
        }
        databaseexe dbexe = new databaseexe();
        private void frmMaterialIn4_Load(object sender, EventArgs e)
        {
            MaterialIndataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select MatinId as 入仓单号,id as 采购序号,SupShort as 供方,MaterialName as 纸板,BomSize as 规格,MatinQuantity as 数量,MatDate as 入仓日期,deliveryDate as 交期 from T_Matin2 where Matinid is not null";
            MaterialIndataGridView1.DataSource =
            dbexe.getdataset(sql, "T_matin2").Tables[0];
            MaterialIndataGridView1.EnableHeadersVisualStyles = false;
            MaterialIndataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            MaterialIndataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            MaterialIndataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select MatinId as 入仓单号,id as 采购序号,SupShort as 供方,MaterialName as 纸板,BomSize as 规格,MatinQuantity as 数量,MatDate as 入仓日期,deliveryDate as 交期 from T_Matin2 where Matinid is not null";
            MaterialIndataGridView1.DataSource =
            dbexe.getdataset(sql, "T_Matin2").Tables[0];
        }
    }
}
