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
    public partial class frmMaterial : Form
    {
        public frmMaterial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        databaseexe dbexe = new databaseexe();
        private void frmMaterial_Load(object sender, EventArgs e)
        {
            MaterialdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql = "select MaterialId as 纸板编码,MaterialName as 纸板名称, MaterialType as 瓦楞类型 from T_material";
            MaterialdataGridView1.DataSource =
            dbexe.getdataset(sql, "T_material").Tables[0];
            MaterialdataGridView1.EnableHeadersVisualStyles = false;
            MaterialdataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            MaterialdataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            MaterialdataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            frmMaterialAdd frmMaterialAdd = new frmMaterialAdd();
            frmMaterialAdd.Show();
            frmMaterialAdd.textBoxID.Enabled = true;
            frmMaterialAdd.buttonSave.Enabled = false;
            frmMaterialAdd.buttonSaveNew.Enabled = true;

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
                    string MaterialID = textBoxNo.Text.Trim();
                    string sql = "select MaterialId as 纸板编码,MaterialName as 纸板名称, MaterialType as 瓦楞类型 from T_material where MaterialId like'%" + MaterialID + "%'";
                    DataTable dt =
                    dbexe.getdataset(sql, "T_Supplier").Tables[0];
                    MaterialdataGridView1.DataSource = dt;
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
                    MessageBox.Show("查询名称不得为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string MaterialName = textBoxName.Text.Trim();
                    string sql = "select MaterialId as 纸板编码,MaterialName as 纸板名称, MaterialType as 瓦楞类型 from T_material where MaterialName like'%" + MaterialName + "%'";
                    try
                    {
                        Connstr connstr = new Connstr();
                        databaseexe dbexe = new databaseexe();
                        DataTable dt =
                        dbexe.getdataset(sql, "T_Supplier").Tables[0];
                        MaterialdataGridView1.DataSource = dt;
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
            frmMaterialAdd frmsub = new frmMaterialAdd(MaterialdataGridView1.CurrentRow);

            frmsub.Show();
            frmsub.buttonSave.Enabled = true;
            frmsub.buttonSaveNew.Enabled = false;
            
        }

        private void MaterialdataGridView1_DoubleClick(object sender, EventArgs e)
        {
           frmMaterialAdd frmsub = new frmMaterialAdd(MaterialdataGridView1.CurrentRow);

            frmsub.Show();
            frmsub.buttonSaveNew.Enabled = false;
            frmsub.buttonSave.Enabled = true;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql1 = "select materialId as 纸板编码,materialName as 纸板名称, materialType as 瓦楞类型 from T_Material ";
            MaterialdataGridView1.DataSource =
            dbexe.getdataset(sql1, "T_material").Tables[0];

        }
    }
}
