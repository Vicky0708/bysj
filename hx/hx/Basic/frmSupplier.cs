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
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked)
            {
                if (textBoxNo.Text == "")
                {
                    MessageBox.Show("未输入编号！");
                    return;
                }
                try
                {
                    Connstr connstr = new Connstr();
                    databaseexe dbexe = new databaseexe();
                    string SupId = textBoxNo.Text.Trim();
                    string sql = "select SupId as 供方编码,SupShort as 供方简称, SupName as 供方全称, SupTelephone as 电话,SupFax as 传真,SupAdress as 地址,SupPerson as 负责人 from T_Supplier where SupId like'%" + SupId + "%'";
                    DataTable dt =
                    dbexe.getdataset(sql, "T_Supplier").Tables[0];
                    SupplierdataGridView.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("没有符合条件的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonModify.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("查询到：" + dt.Rows.Count + " 条记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonModify.Enabled = true;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                if (textBoxName.Text == "")
                {
                    MessageBox.Show("查询供方名称不得为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string SupShort = textBoxName.Text.Trim();
                    string sql = "select SupId as 供方编码,SupShort as 供方简称, SupName as 供方全称, SupTelephone as 电话,SupFax as 传真,SupAdress as 地址,SupPerson as 负责人 from T_Supplier where SupShort like'%" + SupShort + "%'";
                    try
                    {
                        Connstr connstr = new Connstr();
                        databaseexe dbexe = new databaseexe();
                        DataTable dt =
                        dbexe.getdataset(sql, "T_Supplier").Tables[0];
                        SupplierdataGridView.DataSource = dt;
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("没有符合条件的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            buttonModify.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("查询到：" + dt.Rows.Count + " 条记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            buttonModify.Enabled = true;

                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            frmSupplierPrice frmsub1 = new frmSupplierPrice(SupplierdataGridView.CurrentRow);
            frmsub1.Show();

        }
        databaseexe dbexe = new databaseexe();

        private void frmSupplier_Load(object sender, EventArgs e)
        {
           SupplierdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
            string sql = "select SupId as 供方编码,SupShort as 供方简称, SupName as 供方全称, SupTelephone as 电话,SupFax as 传真,SupAdress as 地址,SupPerson as 负责人 from T_Supplier ";
            SupplierdataGridView.DataSource =
            dbexe.getdataset(sql, "T_supplier").Tables[0];
            SupplierdataGridView.EnableHeadersVisualStyles = false;
            SupplierdataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            SupplierdataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            SupplierdataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int rowid = SupplierdataGridView.CurrentRow.Index;
            frmSupplierAdd frmSupplierAdd = new frmSupplierAdd();
            frmSupplierAdd.Show();
            frmSupplierAdd.textBoxSupId.Enabled = true;
            frmSupplierAdd.buttonSaveNew.Enabled = true;
            frmSupplierAdd.buttonSave.Enabled = false;

           
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {

            int totalrow = SupplierdataGridView.ColumnCount;

            int rowid = SupplierdataGridView.CurrentRow.Index;
            frmSupplierAdd frmSupplierAdd = new frmSupplierAdd();
            frmSupplierAdd frmsub = new frmSupplierAdd(SupplierdataGridView.CurrentRow, rowid, totalrow);
            frmsub.Show();
            
            frmsub.buttonSaveNew.Enabled = false;
            frmsub.buttonSave.Enabled = true;



        }

        private void textBoxNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            textBoxName.Clear();
        }

        private void radioButtonName_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNo.Clear();
        }

        private void SupplierdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* frmSupplierPrice frmsub1 = new frmSupplierPrice(SupplierdataGridView.CurrentRow);
            frmsub1.Show();*/
        }
      
        private void SupplierdataGridView_DoubleClick(object sender, EventArgs e)
        {
            int  SupplierdataRowid = SupplierdataGridView.CurrentRow.Index;
            int totalrow = SupplierdataGridView.ColumnCount;
            frmSupplierAdd frmsub = new frmSupplierAdd(SupplierdataGridView.CurrentRow, SupplierdataRowid,totalrow);
            
      
            frmsub.Show();
            frmsub.buttonSave.Enabled = true;
            frmsub.buttonSaveNew.Enabled = false;
        }

        private void SupplierdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          /* frmSupplierPrice frmsub1 = new frmSupplierPrice(SupplierdataGridView.CurrentRow);
            frmsub1.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //databaseexe dbexe = new databaseexe();
            string sql1 = "select SupId as 供方编码,SupShort as 供方简称, SupName as 供方全称, SupTelephone as 电话,SupFax as 传真,SupAdress as 地址,SupPerson as 负责人 from T_Supplier ";
            SupplierdataGridView.DataSource =
            dbexe.getdataset(sql1, "T_Supplier").Tables[0];

        }
    }
}
