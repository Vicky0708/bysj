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
    public partial class frmMatCho4 : Form
    {
        string Matindate,Matdate,MatPerson;
        public frmMatCho4(string id, string id2,string id3)
        {
            InitializeComponent();
            Matindate = id;
            Matdate = id2;
            MatPerson = id3;

        }


        public frmMatCho4()
        {
            InitializeComponent();
        }
        databaseexe dbexe = new databaseexe();
        string MatInID;
        private void frmMatCho4_Load(object sender, EventArgs e)
        {
            MatInGenerator matIn = new MatInGenerator();
            MatInID = matIn.MatinGenerator();

            string SupQuery = "select SupShort from T_Supplier";
            DataTable dk =
            dbexe.getdataset(SupQuery, " T_supplier").Tables[0];

            for (int i = 0; i < dk.Rows.Count; i++)
            {
                DataRow dc = dk.Rows[i];
                comboBox1.Items.Add(dc["supShort"]);

            }

            if (dk.Rows.Count > 0)
            {
                comboBox1.SelectedIndex = -1;

            }

            // PurchaseGenerator pur = new PurchaseGenerator();
            //PurchaseId = pur.purchaseGenerator();
            /*ChooseProductGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql = "select SupShort as 供方,purid as 采购序号,MaterialName as 纸板名称,bomsize as 规格,PurchaseQuantity as 采购数量,MatQuantity as 进料数量,(purchaseQuantity-matquantity)as 未进数量,PurchaseDate as 订货日期,deliverydate as 交货日期 from T_Matin2 where id is null and purid is not null and purchaseQuantity <> '0'";

            DataTable Datatable;
            Datatable = dbexe.getdataset(sql, "T_MATin2").Tables[0];
            for (int i = 0; i < Datatable.Rows.Count; i++) {
                if (Datatable.Rows[i]["进料数量"].ToString() == "") {
                    Datatable.Rows[i]["进料数量"] = "0";
                    Datatable.Rows[i]["未进数量"] = Datatable.Rows[i]["采购数量"];
                }
            }
            ChooseProductGridView1.DataSource = Datatable;
            ChooseProductGridView1.EnableHeadersVisualStyles = false;
            ChooseProductGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 11, FontStyle.Bold);
            ChooseProductGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            ChooseProductGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;*/
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SupShort = comboBox1.Text.ToString();
            ChooseProductGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql = "select SupShort as 供方,purid as 采购序号,MaterialName as 纸板名称,bomsize as 规格,PurchaseQuantity as 采购数量,MatQuantity as 进料数量,(purchaseQuantity-matquantity)as 未进数量,PurchaseDate as 订货日期,deliverydate as 交货日期 from T_Matin2 where id is null and purid is not null and  purchaseQuantity <> '0' and Supshort ='"+SupShort+"' or id  in(select max(id) from T_Matin2 group by Purid having max(id)is not null ) and  purchaseQuantity <> '0' and Supshort ='"+SupShort+"'";

            DataTable Datatable;
            Datatable = dbexe.getdataset(sql, "T_MATin2").Tables[0];
            for (int i = 0; i < Datatable.Rows.Count; i++)
            {
                if (Datatable.Rows[i]["进料数量"].ToString() == "")
                {
                    Datatable.Rows[i]["进料数量"] = "0";
                    Datatable.Rows[i]["未进数量"] = Datatable.Rows[i]["采购数量"];
                }
                else if(int.Parse(Datatable.Rows[i]["未进数量"].ToString()) <= 0)
                {
                    Datatable.Rows[i]["未进数量"] = "0";
                    //Datatable.Rows[i]["进料数量"] = Datatable.Rows[i]["采购数量"];
                }
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
                string PurId = ChooseProductGridView1.CurrentRow.Cells[1].Value.ToString();
                dataValue.CurrentQuantity = ChooseProductGridView1.CurrentRow.Cells[5].Value.ToString();
                string SupShort = comboBox1.Text.ToString();
                string SupidQuery = "select Supid from T_Supplier where SupShort='" + SupShort + "'";
                string Supid = databaseexe.getTopselect(SupidQuery, "Supid");
                string sql1 = "insert into T_MaterialIn (Matinid,PurId,Supid,MatinDate,MatDate,MatinPerson) values('"+MatInID+"','" + PurId + "','" + Supid + "','"+Matindate+"','"+Matdate+"','"+MatPerson+"')";
                dbexe.sqlcmd(sql1);
                string sql = "select SupShort as 供方,purid as 采购序号,MaterialName as 纸板名称,bomsize as 规格,PurchaseQuantity as 采购数量,MatQuantity as 进料数量,(purchaseQuantity-matquantity)as 未进数量,PurchaseDate as 订货日期,deliverydate as 交货日期 from T_Matin2 where id is null and purid is not null and  purchaseQuantity <> '0' and Supshort ='" + SupShort + "' or id  in(select max(id) from T_Matin2 group by Purid having max(id)is not null ) and  purchaseQuantity <> '0' and Supshort ='" + SupShort + "'";

                DataTable Datatable;
                Datatable = dbexe.getdataset(sql, "T_MATin2").Tables[0];
                for (int i = 0; i < Datatable.Rows.Count; i++)
                {
                    if (Datatable.Rows[i]["进料数量"].ToString() == "")
                    {
                        Datatable.Rows[i]["进料数量"] = "0";
                        Datatable.Rows[i]["未进数量"] = Datatable.Rows[i]["采购数量"];
                    }
                }
                ChooseProductGridView1.DataSource = Datatable;

                string QuantityRefresh="update T_Matin3 set MatQuantity='"+dataValue.CurrentQuantity+"'where matinid='"+MatInID+"'and purid='"+PurId+"'";
                dbexe.sqlcmd(QuantityRefresh);
                

                frmMaterialInOrder4 f1 = (frmMaterialInOrder4)this.Owner;
                f1.dgload(Supid,MatInID,PurId);
                //f1.dgload2(PurId);
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            


        }
    }
}
