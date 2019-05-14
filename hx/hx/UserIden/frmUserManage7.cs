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
    public partial class frmUserManage7 : Form
    {
        public frmUserManage7()
        {
            InitializeComponent();
        }

        private void frmUserManage7_Load(object sender, EventArgs e)
        {

        }
        databaseexe dbexe = new databaseexe();
        private void buttonModify_Click(object sender, EventArgs e)
        {
           /* try
            {
                Boolean Manager = checkBoxManger.Checked;
                Boolean Saler = checkBoxSale.Checked;
                Boolean Manuer = checkBoxManu.Checked;
                Boolean purchaser = checkBoxPurchase.Checked;
                Boolean Stocker = checkBoxStock.Checked;
                Boolean Financer = checkBoxFinance.Checked;
                string UserMemo = textBoxMemo.Text.ToString();
                string IdQuery = "select ID from T_user where username ='" + dataValue.StaffName + "'";
                databaseexe databaseexe = new databaseexe();
                string id = databaseexe.getTopselect(IdQuery, "ID");
                string sql = "update T_User set memo ='" + UserMemo + "',where Id='" + id + "'";
                dbexe.sqlcmd(sql);
                if (Manager.Equals(true))
                {
                    string sql2 = "update T_user set identity ='1' where id='" +id + "'";
                    dbexe.sqlcmd(sql2);

                }
                if (Saler.Equals(true))
                {
                    string sql3 = "update T_user set identityy ='2' where id='" + id + "'";
                    dbexe.sqlcmd(sql3);
                }
                if (dading.Equals(true))
                {
                    string sql4 = "update T_fixPRO set dading ='true' where id='" + FixID + "'";
                    dbexe.sqlcmd(sql4);

                }
                if (yinshua.Equals(false))
                {
                    string sql5 = "update T_fixPRO set yingshua ='false' where id='" + FixID + "'";
                    dbexe.sqlcmd(sql5);

                }
                if (zhanjiao.Equals(false))
                {
                    string sql6 = "update T_fixPRO set zhanjiao ='false' where id='" + FixID + "'";
                    dbexe.sqlcmd(sql6);


                }
                if (dading.Equals(false))
                {
                    string sql7 = "update T_fixPRO set dading ='false' where id='" + FixID + "'";
                    dbexe.sqlcmd(sql7);

                }
                MessageBox.Show("数据修改成功!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
