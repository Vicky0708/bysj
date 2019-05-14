using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hx
{
    public partial class frmDeliveryAdd5 : Form
    {
        string deliveryid, Zhuananid,CusShort;
        public frmDeliveryAdd5()
        {
            InitializeComponent();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            string DeliveryPerson = textBoxperson.Text.ToString();
            string DeliveryInDate=DeliveryDateTimePicker1.Value.ToShortDateString();
            string DeliveryDate = textBoxDeliveryDate.Text.ToString();
            frmDeliveryChoose5 frmsub = new frmDeliveryChoose5(DeliveryPerson,DeliveryInDate,DeliveryDate);
            frmsub.Show();
            frmsub.Owner = this;
        }

        private void frmDeliveryAdd5_Load(object sender, EventArgs e)
        {
            textBoxperson.Text = dataValue.StaffName.ToString();
            textBoxDeliveryDate.Text =DateTime.Now.ToShortDateString();
            dgload(deliveryid,Zhuananid,CusShort);
        }
        databaseexe dbexe = new databaseexe();

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeliverydataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string zhuananid = DeliverydataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string changestring = DeliverydataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            string deliveryId = textBoxDeliveryID.Text.ToString();
            try
            {
                databaseexe databaseexe = new databaseexe();
                //string QuantityNow = ClientdataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                //int CurrentQuantity = int.Parse(QuantityNow) + int.Parse(changestring);

                string QuantityQuery = "select sum(deliveryoutquantity) as a from T_deliveryOut group by zhuananID having sum(deliveryoutquantity)is not null and zhuananID='" + zhuananid + "'";
                string lastQuantity = databaseexe.getTopselect(QuantityQuery, "a");
                int CurrentQuantity = int.Parse(lastQuantity) + int.Parse(changestring);
                string sql = "update T_deliveryOut set deliveryoutquantity ='" + changestring + "',deliveryquantity ='" + CurrentQuantity + "'where zhuananid ='" + zhuananid + "'and deliveryid='" + textBoxDeliveryID.Text.ToString() + "'";
                databaseexe.sqlcmd(sql);
                this.BeginInvoke(new MethodInvoker(() => {//异步处理

                    string sql1 = "select CusShort as 客户,zhuananid as 专案编号,productName as 品名,productType as 箱式,materialName as 纸板名称,plength as 长,pwide as 宽,pheight as 高,unit as 单位,deliveryoutquantity as 出货数量,price as 单价,(deliveryOutquantity*price) as 金额 from T_DelOut where deliveryid='" + deliveryId + "'";

                    //DeliverydataGridView1.DataSource =

                    //dbexe.getdataset(sql1, "T_delout").Tables[0];
                    //string sql = "select CusShort as 客户,zhuananid as 专案编号,Orderid as 订单号,productName as 品名,producttYPE as 箱式,plength as 长,pwide as 宽,pheight as 高,unit as 单位,materialName as 纸板名称,orderquantity as 订单数量, deliveryquantity as 已送数量,(orderquantity-deliveryquantity)as 未送数量,deliverytime as 交货日期 from T_delout where id is null and zhuananid is not null or id  in(select max(id) from T_delout group by zhuananid having max(id)is not null )";

                    DataTable Datatable;
                    Datatable = dbexe.getdataset(sql1, "T_DelOut").Tables[0];

                    DeliverydataGridView1.DataSource = Datatable;
                }));
                this.BeginInvoke(new MethodInvoker(() => {

                    string MatStock = "Update T_fixpro set Stock=Stock-'" + changestring + "' where id=(select pid from T_alls where id='" + zhuananid + "')";
                    dbexe.sqlcmd(MatStock);


                }));
                   



                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void dgload(string deliveryid, string Zhuananid,string CusShort)
        {
            textBoxDeliveryID.Text = deliveryid;
            textBox2.Text = CusShort;
            DeliverydataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select CusShort as 客户,zhuananid as 专案编号,productName as 品名,productType as 箱式,materialName as 纸板名称,plength as 长,pwide as 宽,pheight as 高,unit as 单位,deliveryoutquantity as 出货数量,price as 单价,(deliveryOutquantity*price) as 金额 from T_DelOut where deliveryid='" + deliveryid + "'";



            DataTable datatable = dbexe.getdataset(sql, "T_Delout").Tables[0];
            for (int i = 0; i < datatable.Rows.Count; i++)
            {

                datatable.Rows[i]["出货数量"] = "0";

            }
            DeliverydataGridView1.DataSource = datatable;
            DeliverydataGridView1.EnableHeadersVisualStyles = false;
            DeliverydataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
            DeliverydataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            DeliverydataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
       
        public delegate void MyInvoke(string str);
        public void DoWork(string deliveryId)
         {
             MyInvoke mi = new MyInvoke(dataload(deliveryId));
             this.BeginInvoke(mi);
        }

        private MyInvoke dataload(string deliveryId)
        {

          
            throw new NotImplementedException();
        }
    }
}
