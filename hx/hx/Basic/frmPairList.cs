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
    public partial class frmPairList : Form
    {
        string fatherId;
        public frmPairList(string id)
        {
            InitializeComponent();
            fatherId = id;
        }
        public frmPairList()
        {
            InitializeComponent();
        }
        databaseexe dbexe = new databaseexe();
        private void frmPairList_Load(object sender, EventArgs e)
        {
           PairListdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                string sql = "select id as 编码, productname as 名称,producttype as 纸箱种类, materialname as 纸板材质,plength as 长,pwide as 宽,pheight as 高,unit as 单位,quantity as 数量 from T_fixpro where fatherId='" + fatherId + "'";
                PairListdataGridView.DataSource =
                dbexe.getdataset(sql, "T_Fixpro").Tables[0];
                PairListdataGridView.EnableHeadersVisualStyles = false;
                PairListdataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
                PairListdataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
                PairListdataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
                    databaseexe dbexe = new databaseexe();
                    string PairID = PairListdataGridView.SelectedRows[0].Cells["编码"].Value.ToString();
                    string sql = "delete from T_fixpro where ID='" + PairID + "'";
                    dbexe.sqlcmd(sql);
                    MessageBox.Show("数据删除成功!");
                    PairListdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    string sql1 = "select id as 编码, productname as 名称,producttype as 纸箱种类, materialname as 纸板材质,plength as 长,pwide as 宽,pheight as 高,unit as 单位,quantity as 数量 from T_fixpro where fatherId='" + fatherId + "'";
                    PairListdataGridView.DataSource =
                    dbexe.getdataset(sql1, "T_fixpro").Tables[0];
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                frmPairModify frmsub = new frmPairModify(PairListdataGridView.CurrentRow);
          //  string ClientidQuery = "select CusID from T_fixpair where id ='" + textBoxFixId.Text.Trim() + "'";
          //  frmsub.textBoxClientID.Text = databaseexe.getTopselect(ClientidQuery, "cusID");
            frmsub.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

            
           
        }

        private void PairListdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select id as 编码, productname as 名称,producttype as 纸箱种类, materialname as 纸板材质,plength as 长,pwide as 宽,pheight as 高,unit as 单位,quantity as 数量 from T_fixpro where fatherId='" + fatherId + "'";
            PairListdataGridView.DataSource =
            dbexe.getdataset(sql, "T_Fixpro").Tables[0];
        }
    }
}
