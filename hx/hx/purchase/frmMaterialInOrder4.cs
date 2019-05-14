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
    
    public partial class frmMaterialInOrder4 : Form
    {
        
        string supid, matinid,quantity,purid;
        public frmMaterialInOrder4()
        {
            InitializeComponent();
        }
        private void MaterialIndataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            //在点击单元格时，触发此事件，进行有条件的编辑
        }

        private void frmMaterialInOrder4_Load(object sender, EventArgs e)
        {
          /*  MaterialIndataGridView1.AutoGenerateColumns = true;
            MaterialIndataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            MaterialIndataGridView1.ReadOnly = true;
            MaterialIndataGridView1.Columns[1].ReadOnly = true;
            MaterialIndataGridView1.Rows[0].ReadOnly = true;
            MaterialIndataGridView1[3, 3].ReadOnly = true;
            string strcolumn = MaterialIndataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = MaterialIndataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//获取焦点触发行的第一个值
            string value = MaterialIndataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值*/


            
            //dgload();

        }

        databaseexe dbexe = new databaseexe();
        public void dgload(string supid,string matinid,string purid)
        {
            textBoxProductInId.Text = matinid;
            
            //textBoxSup.Text = supid;
            string SupShortQuery = "select SupShort from t_Supplier where Supid='"+supid+"'";
            databaseexe databaseexe = new databaseexe();
            textBoxSup.Text = databaseexe.getTopselect(SupShortQuery, "Supshort");
            MaterialIndataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select purid as 采购序号,Supshort as 供方,MaterialName as 纸板,bomsize as 规格,MatQuantity as 数量,price as 单价,MatQuantity*price as 金额 from T_Matin2 where Matinid='" + matinid + "'";
           
           

            DataTable datatable=dbexe.getdataset(sql, "T_matin2").Tables[0];
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                
                    datatable.Rows[i]["数量"] = "0";
                
            }
            MaterialIndataGridView1.DataSource = datatable;
          MaterialIndataGridView1.EnableHeadersVisualStyles = false;
            MaterialIndataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
            MaterialIndataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            MaterialIndataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            string quantityNow = dataValue.CurrentQuantity;
            ClientdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql1 = "select Zhuananid as 专案编号,CusShort as 客户,ProductName as 品名,purchaseQuantity as 采购数量,Matquantity as 入仓数量 from T_matin3  where matinid = '" + textBoxProductInId.Text.ToString() + "'";

            ClientdataGridView1.DataSource =

            dbexe.getdataset(sql1, "T_matin3").Tables[0];
            ClientdataGridView1.EnableHeadersVisualStyles = false;
            ClientdataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
            ClientdataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            ClientdataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        private void frmMaterialInOrder4_Load_1(object sender, EventArgs e)
        {
            textBoxDingdanDate.Text = DateTime.Now.ToShortDateString();
            textBoxperson.Text = dataValue.StaffName.ToString();
            dgload(supid, matinid,purid);
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            string MatinDate = CheckdateTimePicker2.Value.ToShortDateString();
            string MatDate = textBoxDingdanDate.Text.ToString();
            string MatPerson = textBoxperson.Text.ToString();
            frmMatCho4 frmsub = new frmMatCho4(MatinDate, MatDate,MatPerson);
            frmsub.Owner = this;
            
            frmsub.Show();
            //string Supid = SupidcomboBox.Text.ToString();
            //frmChoose4 frmsub = new frmChoose4(Supid);
           
            //frmsub.Show();
        }

        private void ClientdataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            //string sql1 = "select Zhuananid as 专案编号,CusShort as 客户,ProductName as 品名,purchaseQuantity as 采购数量,Matquantity as 入仓数量 from T_matin3  where matinuid='" + MatinId + "'";

            
        }

        private void ClientdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void MaterialIndataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string changestring = MaterialIndataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            string Purid = MaterialIndataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            try
            {

                    string QuantityNow = ClientdataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                     
                    int CurrentQuantity = int.Parse(QuantityNow) + int.Parse(changestring);
                    string sql = "update T_MaterialIN set matinquantity ='"+changestring+"',matquantity = '" + CurrentQuantity + "' where id =(select top 1 id from T_matin2 where purid ='" + Purid + "' order by id desc)";
                    databaseexe databaseexe = new databaseexe();
                    databaseexe.sqlcmd(sql);
                // dgload2(purid);

              


                ClientdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                string sql1 = "select Zhuananid as 专案编号,CusShort as 客户,ProductName as 品名,purchaseQuantity as 采购数量,Matquantity as 入仓数量 from T_matin3  where matinid = '" + textBoxProductInId.Text.ToString() + "'";

                ClientdataGridView1.DataSource =

                dbexe.getdataset(sql1, "T_matin3").Tables[0];
                ClientdataGridView1.EnableHeadersVisualStyles = false;
                ClientdataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
                ClientdataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
                ClientdataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                string UniqueId = ClientdataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                string MatStock = "Update T_Bom set Stock=Stock+'" + MaterialIndataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() +"' where bomid=(select bomid from T_pur where ZhuanAnID='"+UniqueId+"')";
                dbexe.sqlcmd(MatStock);
               // string MatStock="update T_Bom set stock="




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

       /* public void dgload2(string PurId)
        {
            /*textBoxProductInId.Text = matinid;

            //textBoxSup.Text = supid;
            string SupShortQuery = "select SupShort from t_Supplier where Supid='" + supid + "'";
            databaseexe databaseexe = new databaseexe();
            textBoxSup.Text = databaseexe.getTopselect(SupShortQuery, "Supshort");
            MaterialIndataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "select purid as 采购序号,Supshort as 供方,MaterialName as 纸板,bomsize as 规格,MatQuantity as 数量,price as 单价,MatQuantity*price as 金额 from T_Matin2 where Matinid='" + matinid + "'";

            MaterialIndataGridView1.DataSource =

            dbexe.getdataset(sql, "T_matin2").Tables[0];
            MaterialIndataGridView1.EnableHeadersVisualStyles = false;
            MaterialIndataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
            MaterialIndataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            MaterialIndataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;*/

           
            /*ClientdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql1 = "select Zhuananid as 专案编号,CusShort as 客户,ProductName as 品名,purchaseQuantity as 采购数量,Matquantity as 入仓数量 from T_matin3  where matinuid=(select top 1 id from T_matin2 where purid ='"+PurId+"' order by id desc)";

            ClientdataGridView1.DataSource =

            dbexe.getdataset(sql1, "T_matin3").Tables[0];
            ClientdataGridView1.EnableHeadersVisualStyles = false;
            ClientdataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
            ClientdataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            ClientdataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }*/



        private void MaterialIndataGridView1_CellValueChanged(object sender,DataGridViewCellEventArgs e)
        {
            
        }


    }
}
