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
    public partial class frmMaterialAdd : Form
    {
        public frmMaterialAdd(DataGridViewRow dgvr1)
        {
            InitializeComponent();
            dgvr = dgvr1;
            getValue();


        }

        public DataGridViewRow dgvr;

        public void getValue()
        {
            try
            {
                textBoxID.Text = dgvr.Cells[0].Value.ToString();
                textBoxName.Text = dgvr.Cells[1].Value.ToString();
                textBoxType.Text = dgvr.Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                
            }
           



        }
        public frmMaterialAdd()
        {
            InitializeComponent();
        }
        databaseexe dbexe = new databaseexe();

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                string MaterialId = textBoxID.Text.Trim();
                string MaterialName = textBoxName.Text.Trim();
                string MaterialType=textBoxType.Text.Trim();
                string sql = "insert into T_Material (MaterialID ,MaterialName,MaterialType) values ('" + MaterialId + "','" + MaterialName+ "','" + MaterialType +  "')";
                dbexe.sqlcmd(sql);
                MessageBox.Show("数据添加成功!");
                /*teacherdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                string sql1 = "select teacherId as 教师编号,teacherName as 教师姓名,tage as 年龄,Tdepartement as 所属学院 from teacher";
                teacherdataGridView1.DataSource =
                dbexe.getdataset(sql1, "teacher").Tables[0];*/

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

        private void frmMaterialAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string MaterialId = textBoxID.Text.Trim();
            string MaterialName = textBoxName.Text.Trim();
            string MaterialType = textBoxType.Text.Trim();
            string sql = "update T_Material set materialName='" + MaterialName + "',materialType='" 
                + MaterialType + "'where materialId = '" + MaterialId + "'";
            dbexe.sqlcmd(sql);
            MessageBox.Show("数据保存成功!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.No)
            {
                return;

            }
            else
            {
                string materialId = textBoxID.Text.ToString();
                string sql = "delete from T_material where materialId='" + materialId + "'";
                dbexe.sqlcmd(sql);
                MessageBox.Show("数据删除成功!");

            }
        }
    }
}
