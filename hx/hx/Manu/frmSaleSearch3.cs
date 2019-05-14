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
    public partial class frmSaleSearch3 : Form
    {
        
        public frmSaleSearch3()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        databaseexe dbexe = new databaseexe();
        string ProInID;
        private void frmSaleSearch3_Load(object sender, EventArgs e)
        {

            SaleOrderdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select Orderid as 订单号,zhuananID as 专案编号,productName as 普通纸箱,materialName as 纸板名称,producttype as 箱式,plength as 订单长,pwide as 订单宽,pheight as 订单高,unit as 单位,price as 单价,orderquantity as 订单数量 from T_manu where id is null and status ='已审核' ";
            SaleOrderdataGridView1.DataSource =
            dbexe.getdataset(sql, "T_manu").Tables[0];
            SaleOrderdataGridView1.EnableHeadersVisualStyles = false;
            SaleOrderdataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            SaleOrderdataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            SaleOrderdataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {
                ManuGenarator manu = new ManuGenarator();
                dataValue.ManuSaleid = SaleOrderdataGridView1.CurrentRow.Cells[0].Value.ToString();
                string ManuOrderid = dataValue.ManuSaleid;
                string ManuId = manu.manuGenerator(ManuOrderid);
                string sql = " Select id from t_ordersale where orderid ='" + ManuOrderid + "'order by id asc";
                databaseexe databaseexe = new databaseexe();
                string[] arr;
                arr = databaseexe.getMultiData(sql, "id");
                for (int i = 0; i < arr.Length; i++)
                {
                    string AllMaterialQuery = " Select unitquantity*orderquantity as a from T_manus where ZhuanAnID = '" + arr[i].ToString() + "'";
                    string AllMaterialQuantity = databaseexe.getTopselect(AllMaterialQuery, "a");
                    string sql1 = "insert into T_manuOrder (manuid,allmaterialquantity,saleid,zhuananid) values('" + ManuId + "','" + AllMaterialQuantity + "','" + ManuOrderid + "','" + arr[i].ToString() + "')";
                    dbexe.sqlcmd(sql1);
                }

                frmManuOrderAdd3 f1 = (frmManuOrderAdd3)this.Owner;
                f1.dgload(ManuOrderid, ManuId);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            /*string orderQuantity = SaleOrderdataGridView1.CurrentRow.Cells[10].Value.ToString();
            string Uniqueid = SaleOrderdataGridView1.CurrentRow.Cells[1].Value.ToString();
            string unitQuantityQuery = "select unitquantity from T_manus where zhuananid ='" + Uniqueid + "'";
            databaseexe databaseexe = new databaseexe();
            string UnitQuantity = databaseexe.getTopselect(unitQuantityQuery, "unitquantity");
            
            AutoCount autoCount = new AutoCount();
            string MaterialAll = autoCount.MaterialCount(orderQuantity,UnitQuantity);
            
            //frmManuOrderAdd3 frmsub = new frmManuOrderAdd3(SaleOrderdataGridView1.CurrentRow);
            //frmsub.Show();


            /* string Orderid = dataValue.saleid;
             frmOrderSaleNew2 frmsub = new frmOrderSaleNew2(Orderid);
             frmOrderSaleNew2.FrmOrderSaleNew2.dgload(Orderid);
             this.Close();*/
            //string Orderid = dataValue.saleid;
            /* dataValue.ManuSaleid = SaleOrderdataGridView1.CurrentRow.Cells[0].Value.ToString();
             string ManuOrderid = dataValue.ManuSaleid;
             Select id  from t_ordersale

             string sql = "insert into T_manuOrder (manuid,saleid,allMaterialQuantity) values ('" + ManuId + "','"+ManuOrderid+ "','"+MaterialAll+"')";
             dbexe.sqlcmd(sql);
             MessageBox.Show("数据添加成功!");*/

            //frmManuOrderAdd3 frmManuOrderAdd3 = new frmManuOrderAdd3(ManuOrderid);


            // frmManuOrderAdd3.FrmManuOrderAdd3.dgload(ManuOrderid);





            this.Close();
            MessageBox.Show("数据添加成功!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
