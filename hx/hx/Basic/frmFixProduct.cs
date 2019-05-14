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
    public partial class frmFixProduct : Form
    {
        public frmFixProduct (DataGridViewRow dgvr1)
        {
            InitializeComponent();
            dgvr = dgvr1;
            getValue();


        }

        public DataGridViewRow dgvr;
        string Id;
        public void getValue()
        {
            Id = dgvr.Cells[0].Value.ToString();

        }
        public frmFixProduct()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        databaseexe dbexe = new databaseexe();

        private void frmFixProduct_Load(object sender, EventArgs e)
        {
            try
            {
                FixProductGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
               string sql = "select id as 编码,ProductName as 品名,productType as 箱式,MaterialName as 材料名称,PLength as 长,Pwide as 宽,Pheight as 高,unit as 单位, Price as 单价  from T_FixPRO where fatherid is null and CusId ='" + Id + "'";
               FixProductGridView1.DataSource =
              dbexe.getdataset(sql, "T_FixPRO").Tables[0];
               FixProductGridView1.EnableHeadersVisualStyles = false;
               FixProductGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
               FixProductGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
               FixProductGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select id as 编码,ProductName as 品名, productType as 箱式,MaterialName as 材料名称,PLength as 长,Pwide as 宽,Pheight as 高,unit as 单位, Price as 单价  from T_FixPRO where fatherid is null and CusId ='" + Id + "'";
            FixProductGridView1.DataSource =
            dbexe.getdataset(sql, "T_FixPRO").Tables[0];
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
                    string ProductId = textBoxNo.Text.Trim();
                    string sql = "select id as 编码,ProductName as 品名, productType as 箱式,PLength as 长,Pwide as 宽,Pheight as 高,unit as 单位, Price as 单价  from T_FixPRO where ID like'%" + ProductId + "%'";
                    DataTable dt =
                    dbexe.getdataset(sql, "T_FixPRO").Tables[0];
                    FixProductGridView1.DataSource = dt;
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
                    MessageBox.Show("查询产品名称不得为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string ProductName = textBoxName.Text.Trim();
                    string sql = "select id as 编码,ProductName as 品名, productType as 箱式,PLength as 长,Pwide as 宽,Pheight as 高,unit as 单位, Price as 单价  from T_FixPRO where ProductName like'%" +ProductName + "%'";
                    try
                    {
                        Connstr connstr = new Connstr();
                        databaseexe dbexe = new databaseexe();
                        DataTable dt =
                        dbexe.getdataset(sql, "T_FixPRO'").Tables[0];
                        FixProductGridView1.DataSource = dt;
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

        private void radioButtonName_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxNo.Clear();
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxName.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            frmFixAdd frmFixAdd = new frmFixAdd(Id);
            frmFixAdd.Show();
            frmFixAdd.buttonSaveNew.Enabled = true;
            frmFixAdd.buttonSave.Enabled = false;
            frmFixAdd.buttonPairSearch.Enabled = false;
        }
        string typeid;
        private void FixProductGridView1_DoubleClick(object sender, EventArgs e)
        {
           typeid = FixProductGridView1.CurrentRow.Cells[0].Value.ToString();

            string QuantityQuery = "select quantity from T_fixpro where id ='" + typeid + "'";
            string Quantity = databaseexe.getTopselect(QuantityQuery, "quantity");

            frmFixAdd frmsub = new frmFixAdd(FixProductGridView1.CurrentRow,Id,typeid,Quantity);

            frmsub.Show();
            frmsub.buttonSave.Enabled = true;
            frmsub.buttonSaveNew.Enabled = false;
        }
        databaseexe databaseexe = new databaseexe();
        private void buttonModify_Click(object sender, EventArgs e)
        {
            try
            {
                typeid = FixProductGridView1.CurrentRow.Cells[0].Value.ToString();
                string QuantityQuery = "select quantity from T_fixpro where id ='" + typeid + "'";
                string Quantity = databaseexe.getTopselect(QuantityQuery, "quantity");

                frmFixAdd frmsub = new frmFixAdd(FixProductGridView1.CurrentRow, Id, typeid,Quantity);

               frmsub.Show();
               frmsub.buttonSave.Enabled = true;
               frmsub.buttonSaveNew.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void FixProductGridView1_DockChanged(object sender, EventArgs e)
        {

        }

        private void FixProductGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
