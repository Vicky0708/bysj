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
    public partial class frmPurchaseManage4 : Form
    {
        public frmPurchaseManage4()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            frmPurchaseAdd4 frmsub = new frmPurchaseAdd4();
            frmsub.Show();
        }
        databaseexe dbexe = new databaseexe(); 
        private void frmPurchaseManage4_Load(object sender, EventArgs e)
        {
           PurchasedataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select Purchaseid as 采购单号,id as 采购序号,supshort as 供方,materialname as 纸板名称,bomsize as 规格, purchasequantity as 数量,price as 单价,(price*purchasequantity) as 金额,deliverydate as 交货日期,purchasedate as 订购日期 from T_suppur where purchaseid is not null";
            PurchasedataGridView1.DataSource =
            dbexe.getdataset(sql, "T_suppur").Tables[0];
            PurchasedataGridView1.EnableHeadersVisualStyles = false;
            PurchasedataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            PurchasedataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            PurchasedataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select Purchaseid as 采购单号,id as 采购序号,supshort as 供方,materialname as 纸板名称,bomsize as 规格, purchasequantity as 数量,price as 单价,(price*purchasequantity) as 金额,deliverydate as 交货日期,purchasedate as 订购日期 from T_suppur where purchaseid is not null";
            PurchasedataGridView1.DataSource =
            dbexe.getdataset(sql, "T_suppur").Tables[0];
        }
    }
}
