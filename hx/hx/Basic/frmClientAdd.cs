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
    public partial class frmClientAdd : Form
    {
        public frmClientAdd(DataGridViewRow dgvr1)
        {
            InitializeComponent();
            dgvr = dgvr1;
            getValue();


        }

        public DataGridViewRow dgvr;

        public void getValue()
        {
            textBoxCusId.Text = dgvr.Cells[0].Value.ToString();
            textBoxCusShort.Text = dgvr.Cells[1].Value.ToString();
            textBoxCusName.Text = dgvr.Cells[2].Value.ToString();
            textBoxCusTel.Text = dgvr.Cells[3].Value.ToString();
            textBoxCusFax.Text = dgvr.Cells[4].Value.ToString();
            textBoxCusAdress.Text = dgvr.Cells[5].Value.ToString();
            textBoxCusPerson.Text = dgvr.Cells[6].Value.ToString();


        }
        public frmClientAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            try
            {
                databaseexe dbexe = new databaseexe();
                string CusId = textBoxCusId.Text.Trim();
                string CusShort = textBoxCusShort.Text.Trim();
                string CusName = textBoxCusName.Text.Trim();
                string CusTel = textBoxCusTel.Text.Trim();
                string CusFax = textBoxCusFax.Text.Trim();
                string CusAdress = textBoxCusAdress.Text.Trim();
                string CusPerson = textBoxCusPerson.Text.Trim();
                string CusBank = textBoxBank.Text.Trim();
                string CusAccount = textBoxAccount.Text.Trim();
                string CusMemo = textBoxMemo.Text.Trim();
                if (CusId == "" || CusShort == "" || CusName == "" || CusTel == "" || CusAdress == "")
                {
                    MessageBox.Show("数据添加不完整");

                }
                else
                {
                    try
                    {
                        string sql = "insert into T_Customer (CusID,CusShort,CusName,CusTelephone,CusFax,CusAdress,CusPerson,CusBank,CusAccount,CusMemo) values ('" + CusId + "','" + CusShort + "','" + CusName + "','" + CusTel + "','" + CusFax + "','" + CusAdress + "','" + CusPerson + "','" + CusBank + "','" + CusAccount + "','" + CusMemo + "')";
                        dbexe.sqlcmd(sql);
                        MessageBox.Show("数据添加成功!");



                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
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
        databaseexe dbexe = new databaseexe();

        private void frmClientAdd_Load(object sender, EventArgs e)
        {
            string sql1 = "select CusBank from  T_customer where CusId='" +textBoxCusId.Text.Trim() + "'";
            
            DataTable de =
                dbexe.getdataset(sql1, "T_customer").Tables[0];
            for (int i = 0; i < de.Rows.Count; i++)
            {
                DataRow dc = de.Rows[i];
                textBoxBank.Text = dc["CusBank"].ToString();

            }
            string sql2 = "select CusAccount from  T_customer where CusId='" + textBoxCusId.Text.Trim() + "'";

            DataTable da =
                dbexe.getdataset(sql2, "T_customer").Tables[0];
            for (int i = 0; i < da.Rows.Count; i++)
            {
                DataRow db = da.Rows[i];
                textBoxAccount.Text = db["CusAccount"].ToString();
            }
            string sql3 = "select CusMemo from  T_customer where CusId='" + textBoxCusId.Text.Trim() + "'";

            DataTable df =
                dbexe.getdataset(sql3, "T_customer").Tables[0];
            for (int i = 0; i < df.Rows.Count; i++)
            {
                DataRow dk = df.Rows[i];
                textBoxMemo.Text = dk["CusMemo"].ToString();

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string CusId = textBoxCusId.Text.Trim();
            string CusShort = textBoxCusShort.Text.Trim();
            string CusName = textBoxCusName.Text.Trim();
            string CusTel = textBoxCusTel.Text.Trim();
            string CusFax = textBoxCusFax.Text.Trim();
            string CusAdress = textBoxCusAdress.Text.Trim();
            string CusPerson = textBoxCusPerson.Text.Trim();
            string CusBank = textBoxBank.Text.Trim();
            string CusAccount = textBoxAccount.Text.Trim();
            string CusMemo = textBoxMemo.Text.Trim();
            string sql = "update T_Customer set CusShort='" + CusShort + "',CusName='" + CusName + "',CusTelephone='" + CusTel + "',CusFax='" + CusFax + "',CusAdress='" + CusAdress + "',CusPerson='" + CusPerson + "',CusBank='"+CusBank+ "',CusAccount='"+CusAccount+ "',CusMemo='"+CusMemo+"'where CusId='" + CusId + "'";
            dbexe.sqlcmd(sql);
            MessageBox.Show("数据保存成功!");
        }

       public void textBoxCusId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogresult = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogresult == DialogResult.No)
                {
                    return;

                }
                else
                {
                   string CusId = textBoxCusId.Text.ToString();
                   string sql = "delete from T_Customer where CusID='" + CusId + "'";
                   dbexe.sqlcmd(sql);
                    MessageBox.Show("数据删除成功!");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
