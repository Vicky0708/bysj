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
    public partial class frmChoose4 : Form
    {
        string Supid;
        public frmChoose4(string supid)
        {
            InitializeComponent();
            Supid = supid;
        }
        databaseexe dbexe = new databaseexe();
        string PurchaseId;
        //string AllMaterialQuery = " Select unitquantity*orderquantity as a from T_manus where ZhuanAnID = '" + arr[i].ToString() + "'";
        //string AllMaterialQuantity = databaseexe.getTopselect(AllMaterialQuery, "a");
        private void frmPurchaseChoose4_Load(object sender, EventArgs e)
        {
            PurchaseGenerator pur = new PurchaseGenerator();
            PurchaseId= pur.purchaseGenerator();         
            PurchaseOrderdataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql = "select zhuananid as 专案编号,CusShort as 客户,productName as 品名," +
                "materialName as 纸板名称,bomsize as 规格, allMaterialQuantity-matstock as 欠料数量" +
                " from T_pur where purchaseid is null and manuid is not null ";
            DataTable Datatable;      
            Datatable = dbexe.getdataset(sql, "T_pur").Tables[0];
            for (int i = 0; i < Datatable.Rows.Count; i++)
            {
                if (int.Parse(Datatable.Rows[i]["欠料数量"].ToString()) < 0)
                {
                    Datatable.Rows[i]["欠料数量"] = "0";
                }
            }
            PurchaseOrderdataGridView2.DataSource = Datatable;
            PurchaseOrderdataGridView2.EnableHeadersVisualStyles = false;
            PurchaseOrderdataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            PurchaseOrderdataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            PurchaseOrderdataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;            
        }

        private void PurchaseOrderdataGridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {

                databaseexe databaseexe = new databaseexe();
                

                string ZhuanAnid = PurchaseOrderdataGridView2.CurrentRow.Cells[0].Value.ToString();
                string PurchaseQuantity = PurchaseOrderdataGridView2.CurrentRow.Cells[5].Value.ToString();

                string BomidQuery = "select bomid from T_pur where zhuananid='" + ZhuanAnid + "'";
                string bomid = databaseexe.getTopselect(BomidQuery, "bomid");
                string priceQuery="Select materialprice from T_BOMPRICE where bomid='"+bomid+"'and Supid='"+Supid+"'";
                string price = databaseexe.getTopselect(priceQuery, "materialprice");
                string sql1 = "insert into T_purchaseOrder (purchaseid,purchasequantity,zhuananid,price,supid) values('" + PurchaseId + "','" + PurchaseQuantity + "','" +ZhuanAnid+ "','"+price+"','"+Supid+"')";
                    dbexe.sqlcmd(sql1);
                /*string sql = "select zhuananid as 专案编号,CusShort as 客户,productName as 品名,materialName as 纸板名称,bomsize as 规格, allMaterialQuantity-matstock as 欠料数量 from T_pur where purchaseid is null and manuid is not null ";
                dbexe.sqlcmd(sql);*/
                string sql2 = "select zhuananid as 专案编号,CusShort as 客户,productName as 品名,materialName as 纸板名称,bomsize as 规格, allMaterialQuantity-matstock as 欠料数量 from T_pur where purchaseid is null and manuid is not null ";
                
               // dbexe.getdataset(sql2, "T_pur").Tables[0];
                DataTable Datatable;

                Datatable = dbexe.getdataset(sql2, "T_pur").Tables[0];
                for (int i = 0; i < Datatable.Rows.Count; i++)
                {
                    if (int.Parse(Datatable.Rows[i]["欠料数量"].ToString()) < 0)
                    {
                        Datatable.Rows[i]["欠料数量"] = "0";
                    }
                }

                PurchaseOrderdataGridView2.DataSource = Datatable;
                /*string[] arr;
                arr = databaseexe.getMultiData(sql, "id");
                for (int i = 0; i < arr.Length; i++)
                {
                    

                    //string AllMaterialQuery = " Select unitquantity*orderquantity as a from T_manus where ZhuanAnID = '" + arr[i].ToString() + "'";
                    //string AllMaterialQuantity = databaseexe.getTopselect(AllMaterialQuery, "a");
                    //string PurchaseQuantity="update T_PurchaseOrder set purchasequantity='"+PurchaseOrderdataGridView2.CurrentRow.Cells[5].Value.ToString()+"'where zhuananid= '"+ZhuanAnid+"'";

                }*/

                frmPurchaseAdd4 f1 = (frmPurchaseAdd4)this.Owner;
                f1.dgload(PurchaseId);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            string UniqueId = textBoxId.Text.ToString();
            string productName = textBoxProductNAME.Text.ToString();
            string CusShort = textBoxCusShort.Text.ToString();
            if (UniqueId != "")
            {

                try
                {
                    //string CusId = textBoxNo.Text.Trim();
                    string sql = "select zhuananid as 专案编号,CusShort as 客户,productName as 品名," +
                 "materialName as 纸板名称,bomsize as 规格, allMaterialQuantity-matstock as 欠料数量" +
                 " from T_pur where purchaseid is null and manuid is not null and zhuananid ='" + UniqueId + "'";


                    //DataTable Datatable;
                   // Datatable = dbexe.getdataset(sql, "T_pur").Tables[0];
                   


                    DataTable dt =

                    dbexe.getdataset(sql, "T_pur").Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (int.Parse(dt.Rows[i]["欠料数量"].ToString()) < 0)
                        {
                            dt.Rows[i]["欠料数量"] = "0";
                        }
                    }
                    PurchaseOrderdataGridView2.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("没有符合条件的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

                    }
                    else
                    {
                        MessageBox.Show("查询到：" + dt.Rows.Count + " 条记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else if (productName != "")
            {


                try
                {
                    //string CusId = textBoxNo.Text.Trim();
                    string sql = "select zhuananid as 专案编号,CusShort as 客户,productName as 品名," +
                 "materialName as 纸板名称,bomsize as 规格, allMaterialQuantity-matstock as 欠料数量" +
                 " from T_pur where purchaseid is null and manuid is not null and ProductName like '%" + productName + "%'";
                    DataTable dt =

                    dbexe.getdataset(sql, "T_pur").Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (int.Parse(dt.Rows[i]["欠料数量"].ToString()) < 0)
                        {
                            dt.Rows[i]["欠料数量"] = "0";
                        }
                    }
                    PurchaseOrderdataGridView2.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("没有符合条件的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("查询到：" + dt.Rows.Count + " 条记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else if (CusShort!="")
            {
                try
                {
                    //string CusId = textBoxNo.Text.Trim();
                    string sql = "select zhuananid as 专案编号,CusShort as 客户,productName as 品名," +
                 "materialName as 纸板名称,bomsize as 规格, allMaterialQuantity-matstock as 欠料数量" +
                 " from T_pur where purchaseid is null and manuid is not null and CusShort like '%" + CusShort + "%'";
                    DataTable dt =

                    dbexe.getdataset(sql, "T_pur").Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (int.Parse(dt.Rows[i]["欠料数量"].ToString()) < 0)
                        {
                            dt.Rows[i]["欠料数量"] = "0";
                        }
                    }
                    PurchaseOrderdataGridView2.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("没有符合条件的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("查询到：" + dt.Rows.Count + " 条记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            else if (productName!=""&&CusShort!="")
            {
                try
                {
                    //string CusId = textBoxNo.Text.Trim();
                    string sql = "select zhuananid as 专案编号,CusShort as 客户,productName as 品名," +
                 "materialName as 纸板名称,bomsize as 规格, allMaterialQuantity-matstock as 欠料数量" +
                 " from T_pur where purchaseid is null and manuid is not null and ProductName like '%" + productName + "%',and CusShort like '%" + CusShort + "%'";
                    DataTable dt =

                    dbexe.getdataset(sql, "T_pur").Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (int.Parse(dt.Rows[i]["欠料数量"].ToString()) < 0)
                        {
                            dt.Rows[i]["欠料数量"] = "0";
                        }
                    }
                    PurchaseOrderdataGridView2.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("没有符合条件的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("查询到：" + dt.Rows.Count + " 条记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (CusShort==""&& productName=="" && UniqueId=="")
            {
                MessageBox.Show("请输入查询条件！");
                return;

            }
            textBoxCusShort.Clear();
            textBoxId.Clear();
            textBoxProductNAME.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
