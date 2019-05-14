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
    public partial class frmDeliveryChoose5 : Form
    {
        string DeliveryPerson,Deliveryindate,DeliveryDate;
        public frmDeliveryChoose5(string id, string id2, string id3)
        {
            InitializeComponent();
            DeliveryPerson = id;
            Deliveryindate = id2;
            DeliveryDate= id3;

        }

        public frmDeliveryChoose5()
        {
            InitializeComponent();
        }
        databaseexe dbexe = new databaseexe();
        string DeliveryId;
        private void frmDeliveryChoose5_Load(object sender, EventArgs e)
        {

           DeliveryGenerator delivery = new DeliveryGenerator();
            DeliveryId = delivery.deliveryGenerator();
            FixProductGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql = "select CusShort as 客户,zhuananid as 专案编号,Orderid as 订单号,productName as 品名,producttYPE as 箱式,plength as 长,pwide as 宽,pheight as 高,unit as 单位,materialName as 纸板名称,orderquantity as 订单数量, deliveryquantity as 已送数量,(orderquantity-deliveryquantity)as 未送数量,deliverytime as 交货日期 from T_delout where id is null and zhuananid is not null or id  in(select max(id) from T_delout group by zhuananid having max(id)is not null )";
            DataTable Datatable;
            Datatable = dbexe.getdataset(sql, "T_delout").Tables[0];
            for (int i = 0; i < Datatable.Rows.Count; i++)
            {
                if (Datatable.Rows[i]["已送数量"].ToString() == "")
                {
                    Datatable.Rows[i]["已送数量"] = "0";
                    Datatable.Rows[i]["未送数量"] = Datatable.Rows[i]["订单数量"];
                }
                if (int.Parse(Datatable.Rows[i]["未送数量"].ToString()) < 0)
                {
                    Datatable.Rows[i]["未送数量"] = "0";
                }
                /*else 
                {
                    string QuantityQuery = "select sum(proinquantity) from T_productin group by zhuananID having sum(proinquantity)is not null and zhuananID='"++"'";
                    string Supid = databaseexe.getTopselect(SupidQuery, "Supid");
                }*/


            }

            FixProductGridView1.DataSource = Datatable;
            FixProductGridView1.EnableHeadersVisualStyles = false;
            FixProductGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体",9, FontStyle.Bold);
            FixProductGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            FixProductGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {

                databaseexe databaseexe = new databaseexe();
                string zhuananid = FixProductGridView1.CurrentRow.Cells[1].Value.ToString();
                string CusShort = FixProductGridView1.CurrentRow.Cells[0].Value.ToString();
                //dataValue.CurrentQuantity = ChooseProductGridView1.CurrentRow.Cells[5].Value.ToString();
                //string SupShort = comboBox1.Text.ToString();
                //string SupidQuery = "select Supid from T_Supplier where SupShort='" + SupShort + "'";
                //string Supid = databaseexe.getTopselect(SupidQuery, "Supid");
                string sql1 = "insert into T_DeliveryOut (DeliveryId,zhuananid,deliveryPerson,deliveryindate,deliverydate) values('" + DeliveryId + "','" + zhuananid + "','" + DeliveryPerson + "','" + Deliveryindate + "','" + DeliveryDate + "')";
                dbexe.sqlcmd(sql1);
                string sql = "select CusShort as 客户,zhuananid as 专案编号,Orderid as 订单号,productName as 品名,producttYPE as 箱式,plength as 长,pwide as 宽,pheight as 高,unit as 单位,materialName as 纸板名称,orderquantity as 订单数量, deliveryquantity as 已送数量,(orderquantity-deliveryquantity)as 未送数量,deliverytime as 交货日期 from T_delout where id is null and zhuananid is not null or id  in(select max(id) from T_delout group by zhuananid having max(id)is not null )";

                DataTable Datatable;
                Datatable = dbexe.getdataset(sql, "T_delout").Tables[0];
                for (int i = 0; i < Datatable.Rows.Count; i++)
                {
                    if (Datatable.Rows[i]["已送数量"].ToString() == "")
                    {
                        Datatable.Rows[i]["已送数量"] = "0";
                        Datatable.Rows[i]["未送数量"] = Datatable.Rows[i]["订单数量"];
                    }

                }
                FixProductGridView1.DataSource = Datatable;

                //string QuantityRefresh = "update T_Matin3 set MatQuantity='" + dataValue.CurrentQuantity + "'where matinid='" + MatInID + "'and purid='" + PurId + "'";
                //dbexe.sqlcmd(QuantityRefresh);


                frmDeliveryAdd5 f1 = (frmDeliveryAdd5)this.Owner;
                f1.dgload(DeliveryId, zhuananid,CusShort);
                //f1.dgload2(PurId);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
