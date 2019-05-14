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
    
    public partial class frmPurchaseAdd4 : Form
    {
        string purchaseId;
        public frmPurchaseAdd4(string id)
        {
            InitializeComponent();
            purchaseId = id;
        }

        public frmPurchaseAdd4()
        {
            InitializeComponent();
           // frmPurchaseAdd4 = this;
        }
        //public static frmPurchaseAdd4 frmPurchaseAdd4 = null;
        private void buttonChoose_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonChoose_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (textBoxSupplierName.Text == "")
                {
                    MessageBox.Show("请先选择供方！");
                    return;
                }
                else
                {
                    string Supid = SupidcomboBox.Text.ToString();
                    frmChoose4 frmsub = new frmChoose4(Supid);
                    frmsub.Owner = this;
                    frmsub.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            



            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PurchasedateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmPurchaseAdd4_Load(object sender, EventArgs e)
        {
            textBoxPurchasePerson.Text = dataValue.StaffName.ToString();

            string sql4 = "select Supid from T_Supplier";
            DataTable dk =
            dbexe.getdataset(sql4, " T_supplier").Tables[0];

            for (int i = 0; i < dk.Rows.Count; i++)
            {
                DataRow dc = dk.Rows[i];
                SupidcomboBox.Items.Add(dc["supid"]);

            }

            if (dk.Rows.Count > 0)
            {
               SupidcomboBox.SelectedIndex = -1;

            }
            string sql5 = "select Supshort from T_supplier where supid='" + SupidcomboBox.Text.ToString() + "'";
            DataTable dm =
                dbexe.getdataset(sql5, "T_Supplier").Tables[0];

            for (int i = 0; i < dm.Rows.Count; i++)
            {
                DataRow dc = dm.Rows[i];
                textBoxSupplierName.Text = dc["supshort"].ToString();

            }





            dgload(purchaseId);
        }
        databaseexe dbexe = new databaseexe();
        public void dgload(string purchaseId)
        {
            textBoxPurchaseid.Text = purchaseId;

            PurchaseOrderdataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql = "select id as 采购序号,materialName as 纸板名称, bomsize as 规格,purchasequantity as 数量,price as 单价,purchasequantity*price as 金额 from T_pur where purchaseid='" + purchaseId + "'";

            PurchaseOrderdataGridView2.DataSource =

            dbexe.getdataset(sql, "T_pur").Tables[0];
            PurchaseOrderdataGridView2.EnableHeadersVisualStyles = false;
            PurchaseOrderdataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
            PurchaseOrderdataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            PurchaseOrderdataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


           ClientdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql1 = "select  Zhuananid as 专案编号,CusShort as 客户,ProductName as 品名,AllMaterialQuantity as 用料数量,MAtStock as 存料分配,purchasequantity as 采购数量 from T_pur  where purchaseid='" + purchaseId + "'";

            ClientdataGridView1.DataSource =

            dbexe.getdataset(sql1, "T_pur").Tables[0];
            ClientdataGridView1.EnableHeadersVisualStyles = false;
            ClientdataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
            ClientdataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            ClientdataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;




        }

        private void SupidcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select Supshort from T_Supplier where Supid='" + SupidcomboBox.Text.ToString() + "'";
                DataTable dl =
                    dbexe.getdataset(sql, "T_Supplier").Tables[0];

                for (int i = 0; i < dl.Rows.Count; i++)
                {
                    DataRow dc = dl.Rows[i];
                    textBoxSupplierName.Text = dc["Supshort"].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            string memo = textBoxMemo.Text.ToString();
            string purchasePerson = textBoxPurchasePerson.Text.ToString();
            string PId = textBoxPurchaseid.Text.ToString();
            string sql = "update T_purchaseOrder set purchasePerson='" +purchasePerson + "',purchasedate='" + PurchasedateTimePicker2.Value.ToShortDateString() + "',deliverydate='" + DeliveryTimePicker2.Value.ToShortDateString() + "',memo='" + memo + "'where purchaseid='" + PId  + "'";
            dbexe.sqlcmd(sql);
            MessageBox.Show("1");
        }
    }
}
