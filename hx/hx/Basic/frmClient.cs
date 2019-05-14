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
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }
        databaseexe dbexe = new databaseexe();
        private void frmClient_Load(object sender, EventArgs e)
        {
            ClientdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql = "select CusID as 客户编码,CusShort as 客户简称, CusName as 客户全称, CusTelephone as 电话,CusFax as 传真,CusAdress as 地址,CusPerson as 联系人 from T_customer";
            ClientdataGridView1.DataSource =
            dbexe.getdataset(sql, "T_customer").Tables[0];
            ClientdataGridView1.EnableHeadersVisualStyles = false;
            ClientdataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            ClientdataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            ClientdataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            frmClientAdd frmClientAdd = new frmClientAdd();
            frmClientAdd.Show();
            frmClientAdd.textBoxCusId.Enabled = true;
            frmClientAdd.buttonSave.Enabled = false;
            frmClientAdd.buttonSaveNew.Enabled = true;
            
            
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
                    string CusId = textBoxNo.Text.Trim();
                    string sql = "select CusID as 客户编码,CusShort as 客户简称, CusName as 客户全称, CusTelephone as 电话," +
                        "CusFax as 传真,CusAdress as 地址,CusPerson as 联系人 from T_customer where CusId like'%" + CusId + "%'";
                    DataTable dt =
                    dbexe.getdataset(sql, "T_Customer").Tables[0];
                    ClientdataGridView1.DataSource = dt;
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
                    MessageBox.Show("查询客户名称不得为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string CusShort = textBoxName.Text.Trim();
                    string sql = "select CusID as 客户编码,CusShort as 客户简称, CusName as 客户全称, CusTelephone as 电话,CusFax as 传真,CusAdress as 地址,CusPerson as 联系人 from T_customer where CusShort like'%" +CusShort + "%'";
                    try
                    {
                        Connstr connstr = new Connstr();
                        databaseexe dbexe = new databaseexe();
                        DataTable dt =
                        dbexe.getdataset(sql, "T_customer").Tables[0];
                        ClientdataGridView1.DataSource = dt;
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

        private void radioButtonNo_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
        }

        private void radioButtonName_Click(object sender, EventArgs e)
        {
            textBoxNo.Clear();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            frmClientAdd frmsub = new frmClientAdd(ClientdataGridView1.CurrentRow);

            frmsub.Show();
            frmsub.buttonSave.Enabled = true;
            frmsub.buttonSaveNew.Enabled = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select CusID as 客户编码,CusShort as 客户简称, CusName as 客户全称, CusTelephone as 电话,CusFax as 传真,CusAdress as 地址,CusPerson as 联系人 from T_customer";
            ClientdataGridView1.DataSource =
            dbexe.getdataset(sql, "T_Customer").Tables[0];
        }

        private void ClientdataGridView1_DoubleClick(object sender, EventArgs e)
        {
            frmClientAdd frmsub = new frmClientAdd(ClientdataGridView1.CurrentRow);

            frmsub.Show();
            frmsub.buttonSave.Enabled = true;
            frmsub.buttonSaveNew.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFixProduct frmsub = new frmFixProduct(ClientdataGridView1.CurrentRow);

            frmsub.Show();
        }

        private void ClientdataGridView1_DockChanged(object sender, EventArgs e)
        {

        }
    }
}
