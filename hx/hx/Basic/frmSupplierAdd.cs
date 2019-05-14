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
    public partial class frmSupplierAdd : Form
    {
        int rowid2;
        int totalrow;
        public frmSupplierAdd(DataGridViewRow dgvr1, int rowid, int b)
        {
            rowid2 = rowid;
            totalrow = b;
            InitializeComponent();
            dgvr = dgvr1;
            getValue();
        }

        frmSupplier frmSupplier;
        public DataGridViewRow dgvr;

        public void getValue()
        {
            textBoxSupId.Text = dgvr.Cells[0].Value.ToString();
            textBoxSupShort.Text = dgvr.Cells[1].Value.ToString();
            textBoxSupName.Text = dgvr.Cells[2].Value.ToString();
            textBoxSupTel.Text = dgvr.Cells[3].Value.ToString();
            textBoxSupFax.Text= dgvr.Cells[4].Value.ToString();
            textBoxSupAdress.Text = dgvr.Cells[5].Value.ToString();
            textBoxSupPerson.Text = dgvr.Cells[6].Value.ToString();


        }
        public frmSupplierAdd()
        {
            InitializeComponent();
        }
        private void frmSupplierAdd_Load(object sender, EventArgs e)
        {
            
        }
        databaseexe dbexe = new databaseexe();
        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            try
            {
                //databaseexe dbexe = new databaseexe();
                string SupId = textBoxSupId.Text.Trim();
                string SupShort = textBoxSupShort.Text.Trim();
                string SupName = textBoxSupName.Text.Trim();
                string SupTel = textBoxSupTel.Text.Trim();
                string SupFax = textBoxSupFax.Text.Trim();
                string SupAdress = textBoxSupAdress.Text.Trim();
                string SupPerson = textBoxSupPerson.Text.Trim();
                if (SupId == "" || SupShort == "" || SupName == "" || SupTel == "" || SupFax == "" || SupAdress == "" || SupPerson == "")
                {
                    MessageBox.Show("数据添加不完整");

                }
                else
                {
                    try
                    {
                        string sql = "insert into T_supplier (SupId,SupShort,SupName,SupTelephone,SupFax,SupAdress,SupPerson) values ('" + SupId + "','" + SupShort + "','" + SupName + "','" + SupTel + "','" + SupFax + "','" + SupAdress + "','" + SupPerson + "')";
                        dbexe.sqlcmd(sql);
                        MessageBox.Show("数据添加成功!");



                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }






                }





                /*string sql = "insert into T_supplier (SupId,SupShort,SupName,SupTelelphone,SupFax,SupAdress,SupPerson) values ('" + SupId + "','" + SupShort + "','" + SupName + "','" + SupTel + "','"+SupFax+"','"+SupAdress+"','"+SupPerson+"')";
                dbexe.sqlcmd(sql);
                MessageBox.Show("数据添加成功!");
                CoursedataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                string sql1 = "select courseid as 课程编号,courseName as 课程名称, scoreHour as 课程学时, department as 所属院系 from course";
                CoursedataGridView1.DataSource =
                dbexe.getdataset(sql1, "course").Tables[0];*/

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //databaseexe dbexe = new databaseexe();
            string SupId = textBoxSupId.Text.Trim();
            string SupShort = textBoxSupShort.Text.Trim();
            string SupName = textBoxSupName.Text.Trim();
            string SupTel = textBoxSupTel.Text.Trim();
            string SupFax = textBoxSupFax.Text.Trim();
            string SupAdress = textBoxSupAdress.Text.Trim();
            string SupPerson = textBoxSupPerson.Text.Trim();
            string sql = "update T_Supplier set SupShort='" + SupShort + "',SupName='" + SupName + "',SupTelephone='" + SupTel + "',SupFax='" + SupFax + "',SupAdress='" + SupAdress + "',SupPerson='" + SupPerson + "'where supId='" + SupId + "'";
            dbexe.sqlcmd(sql);
            MessageBox.Show("数据保存成功!");
            /*stuInfodataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql1 = "select studentID as 学号,studentName as 姓名,classname as 班级,department as 学院,sex as 性别,age as 年龄 from Student";
            stuInfodataGridView1.DataSource =
            dbexe.getdataset(sql1, "student").Tables[0];*/
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
                string SupId = textBoxSupId.Text.ToString();
                string sql = "delete from T_Supplier where SupId='" + SupId + "'";
                dbexe.sqlcmd(sql);
                MessageBox.Show("数据删除成功!");

            }
           
           

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (rowid2 < totalrow)
            {
                rowid2 = rowid2 + 1;
                
                //frmSupplier.SupplierdataGridView.Rows[rowid2].Selected = true;
            }

        }
    }

    
}