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
    public partial class frmProInAdd3 : Form
    {
        string proinid, Zhuananid;
        public frmProInAdd3()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            string ProinDate = IndateTimePicker1.Value.ToShortDateString();
            string ProDate = textBoxDingdanDate.Text.ToString();
            string ProPerson = textBoxperson.Text.ToString();
            frmClientChoose3 frmsub = new frmClientChoose3(ProinDate,ProDate,ProPerson);
            frmsub.Show();
            frmsub.Owner = this;

        }

        private void frmProInAdd3_Load(object sender, EventArgs e)
        {
            textBoxDingdanDate.Text = DateTime.Now.ToShortDateString();
            textBoxperson.Text = dataValue.StaffName.ToString();
            dgload(proinid,Zhuananid);
        }
        databaseexe dbexe = new databaseexe();
        public void dgload(string proinid,string Zhuananid)
        {
            textBoxProductInId.Text = proinid;
           ProductIndataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select zhuananid as 专案编号,Cusshort as 客户,productName as 品名,plength as 长,pwide as 宽,pheight as 高,unit as 单位,proinQuantity as 入仓数量 from T_proin where proinid='" + proinid + "'";



            DataTable datatable = dbexe.getdataset(sql, "T_proin").Tables[0];
            for (int i = 0; i < datatable.Rows.Count; i++)
            {

                datatable.Rows[i]["入仓数量"] = "0";

            }
            ProductIndataGridView1.DataSource = datatable;
            ProductIndataGridView1.EnableHeadersVisualStyles = false;
            ProductIndataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
            ProductIndataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            ProductIndataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void ProductIndataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            string zhuananid = ProductIndataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string changestring = ProductIndataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            try
            {
                databaseexe databaseexe = new databaseexe();
                //string QuantityNow = ClientdataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                //int CurrentQuantity = int.Parse(QuantityNow) + int.Parse(changestring);

                string QuantityQuery = "select sum(proinquantity) as a from T_productin group by zhuananID having sum(proinquantity)is not null and zhuananID='"+zhuananid+"'";
                string lastQuantity = databaseexe.getTopselect(QuantityQuery, "a");
                int CurrentQuantity = int.Parse(lastQuantity) + int.Parse(changestring);
                string sql = "update T_productIn set proinquantity ='"+changestring+"',proquantity ='"+CurrentQuantity+"'where zhuananid ='" + zhuananid + "'and proinid='" + textBoxProductInId.Text.ToString() + "'";     
                databaseexe.sqlcmd(sql);
                // dgload2(purid);
                string MatStock = "Update T_fixpro set Stock=Stock+'"+changestring+"' where id=(select pid from T_alls where id='"+zhuananid+"')";
                dbexe.sqlcmd(MatStock);
                 


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

      


    }



}
