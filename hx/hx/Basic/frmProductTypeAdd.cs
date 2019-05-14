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
    public partial class frmProductTypeAdd : Form
    {
        public frmProductTypeAdd(DataGridViewRow dgvr1)
        {
            InitializeComponent();
            dgvr = dgvr1;
            getValue();


        }

        public DataGridViewRow dgvr;
        public void getValue()
        {
            textBoxID.Text = dgvr.Cells[0].Value.ToString();
            textBoxName.Text = dgvr.Cells[1].Value.ToString();

        }
        public frmProductTypeAdd()
        {
            InitializeComponent();
        }
        databaseexe dbexe = new databaseexe();
        private void frmProductTypeAdd_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select ProductDouble from T_productType where id ='" + textBoxID.Text.Trim() + "'";

                DataTable de =
                    dbexe.getdataset(sql, "T_productType").Tables[0];
                for (int i = 0; i < de.Rows.Count; i++)
                {
                    DataRow dc = de.Rows[i];
                    comboBoxDouble.Text = dc["ProductDouble"].ToString();
                }
                string sql1 = "select productDing from T_productType where id ='" + textBoxID.Text.Trim() + "'";

                DataTable da =
                    dbexe.getdataset(sql1, "T_productType").Tables[0];
                for (int i = 0; i < da.Rows.Count; i++)
                {
                    DataRow db = da.Rows[i];
                    comboBoxDing.Text = db["productDing"].ToString();
                }
                string sql2 = "select Price from T_productType where id='" + textBoxID.Text.Trim() + "'";

                DataTable df =
                    dbexe.getdataset(sql2, "T_productType").Tables[0];
                for (int i = 0; i < df.Rows.Count; i++)
                {
                    DataRow dk = df.Rows[i];
                    textBoxPrice.Text = dk["Price"].ToString();

                }
                string sql3 = "select productLength from T_productType where id='" + textBoxID.Text.Trim() + "'";

                DataTable dz =
                    dbexe.getdataset(sql3, "T_productType").Tables[0];
                for (int i = 0; i < dz.Rows.Count; i++)
                {
                    DataRow dp = dz.Rows[i];
                    textBoxLong.Text = dp["productLength"].ToString();

                }
                string sql4 = "select productweight from T_productType where id='" + textBoxID.Text.Trim() + "'";

                DataTable di =
                    dbexe.getdataset(sql4, "T_productType").Tables[0];
                for (int i = 0; i < di.Rows.Count; i++)
                {
                    DataRow dj = di.Rows[i];
                    textBoxWeight.Text = dj["productweight"].ToString();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string Id = textBoxID.Text.Trim();
            string TypeName = textBoxName.Text.Trim();
            string productDouble = comboBoxDouble.Text.Trim();
            string productDing = comboBoxDing.Text.Trim();
            string price = textBoxPrice.Text.Trim();
            string productlength = textBoxLong.Text.Trim();
            string productWeight = textBoxWeight.Text.Trim();
            string sql = "update T_ProductType set TypeName='" + TypeName+ "',productDouble='" +productDouble + "',productding='"+productDing+ "',price='"+price+"',productLength='" + productlength + "',productweight='"+productWeight+"' where id = '" + Id + "'";
            dbexe.sqlcmd(sql);
            MessageBox.Show("数据保存成功!");
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {

            try
            {
                string Id = textBoxID.Text.Trim();
                string TypeName = textBoxName.Text.Trim();
                string productDouble = comboBoxDouble.Text.Trim();
                string productDing = comboBoxDing.Text.Trim();
                string price = textBoxPrice.Text.Trim();
                string productlength = textBoxLong.Text.Trim();
                string productWeight = textBoxWeight.Text.Trim();
                string sql = "insert into T_ProductType (TypeName,productDouble,productDing,Price,productLength,productWeight) values ('" +TypeName + "','" + productDouble + "','" + productDing + "','"+price+ "','"+productlength+"','"+productWeight+ "')";
                dbexe.sqlcmd(sql);
                MessageBox.Show("数据添加成功!");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                string id = textBoxID.Text.ToString();
                string sql = "delete from T_productType where id='" + id+ "'";
                dbexe.sqlcmd(sql);
                MessageBox.Show("数据删除成功!");

            }
        }
    }
}
