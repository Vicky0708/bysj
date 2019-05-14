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
    public partial class frmClientChoose3 : Form
    {
        string proInDate, ProDate, ProPerson;
        public frmClientChoose3(string id, string id2, string id3)
        {
            InitializeComponent();
            proInDate = id;
            ProDate = id2;
            ProPerson = id3;

        }
        public frmClientChoose3()
        {
            InitializeComponent();
        }
        databaseexe dbexe = new databaseexe();

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        string ProInID;
        private void frmClientChoose3_Load(object sender, EventArgs e)
        {
            ProInGenerator proIn = new ProInGenerator();
            ProInID = proIn.proInGenerator();
            ChooseProductGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql = "select CusShort as 客户,zhuananid as 专案编号,productName as 品名,producttYPE as 箱式,plength as 长,pwide as 宽,pheight as 高,unit as 单位,materialName as 纸板名称,orderquantity as 订单数量,proquantity as 已产数量,(orderquantity-proquantity)as 未产数量 from T_proin where id is null and zhuananid is not null or id  in(select max(id) from T_proin group by zhuananid having max(id)is not null )";

            DataTable Datatable;
            Datatable = dbexe.getdataset(sql, "T_proin").Tables[0];



            for (int i = 0; i < Datatable.Rows.Count; i++)
            {
                if (Datatable.Rows[i]["已产数量"].ToString() == "")
                {
                    Datatable.Rows[i]["已产数量"] = "0";
                    Datatable.Rows[i]["未产数量"] = Datatable.Rows[i]["订单数量"];
                }
                /*else 
                {
                    string QuantityQuery = "select sum(proinquantity) from T_productin group by zhuananID having sum(proinquantity)is not null and zhuananID='"++"'";
                    string Supid = databaseexe.getTopselect(SupidQuery, "Supid");
                }*/


            }

            ChooseProductGridView1.DataSource = Datatable;
            ChooseProductGridView1.EnableHeadersVisualStyles = false;
            ChooseProductGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            ChooseProductGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            ChooseProductGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {

                databaseexe databaseexe = new databaseexe();
                string zhuananid = ChooseProductGridView1.CurrentRow.Cells[1].Value.ToString();
                //dataValue.CurrentQuantity = ChooseProductGridView1.CurrentRow.Cells[5].Value.ToString();
                //string SupShort = comboBox1.Text.ToString();
                //string SupidQuery = "select Supid from T_Supplier where SupShort='" + SupShort + "'";
                //string Supid = databaseexe.getTopselect(SupidQuery, "Supid");
                string sql1 = "insert into T_productIn (ProinId,zhuananid,proinPerson,proindate,prodate) values('" + ProInID + "','" + zhuananid + "','" + ProPerson + "','" + proInDate + "','" + ProDate + "')";
                dbexe.sqlcmd(sql1);
                string sql = "select CusShort as 客户,zhuananid as 专案编号,productName as 品名,producttYPE as 箱式,plength as 长,pwide as 宽,pheight as 高,unit as 单位,materialName as 纸板名称,orderquantity as 订单数量,proquantity as 已产数量,(orderquantity-proquantity)as 未产数量 from T_proin where id is null and zhuananid is not null or id  in(select max(id) from T_proin group by zhuananid having max(id)is not null )";

                DataTable Datatable;
                Datatable = dbexe.getdataset(sql, "T_proin").Tables[0];
                for (int i = 0; i < Datatable.Rows.Count; i++)
                {
                    if (Datatable.Rows[i]["已产数量"].ToString() == "")
                    {
                        Datatable.Rows[i]["已产数量"] = "0";
                        Datatable.Rows[i]["未产数量"] = Datatable.Rows[i]["订单数量"];
                    }

                }
                ChooseProductGridView1.DataSource = Datatable;

                //string QuantityRefresh = "update T_Matin3 set MatQuantity='" + dataValue.CurrentQuantity + "'where matinid='" + MatInID + "'and purid='" + PurId + "'";
                //dbexe.sqlcmd(QuantityRefresh);


                frmProInAdd3 f1 = (frmProInAdd3)this.Owner;
                f1.dgload(ProInID, zhuananid);
                //f1.dgload2(PurId);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
