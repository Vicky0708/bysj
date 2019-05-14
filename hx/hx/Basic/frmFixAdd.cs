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
    public partial class frmFixAdd : Form
    {
        string clientID;
        string typeId;
        string MaterialId;
        string Quantity;
        public frmFixAdd(string id)
        {
            InitializeComponent();
            clientID = id;
        }
       public frmFixAdd(DataGridViewRow dgvr1,string id,string tid,string quantity)
        {
            InitializeComponent();
            dgvr = dgvr1;
            getValue();
            clientID = id;
            typeId = tid;
            Quantity = quantity;
            
            string tidquery = "select typeid from T_FixPRO where id ='" + typeId + "'";
            databaseexe databaseexe = new databaseexe();
            tid = databaseexe.getTopselect(tidquery, "typeid");
            string mIdQuery = "select materialID from T_FixPRO where id ='" + typeId + "'";
            MaterialId = databaseexe.getTopselect(mIdQuery, "materialId");
            comboBoxTypeID.Text = tid;
            
            string MnameQuery = "select materialID from T_MATERIAL where id ='" + MaterialId + "'";
            comboBoxMaterialID.Text = databaseexe.getTopselect(MnameQuery,"materialID");
            string PriceQuery = "select price from T_fixpro where id ='" + textBoxFixId.Text + "'";
            textBoxPrice.Text = databaseexe.getTopselect(PriceQuery, "price");

            string yinshuaQuery = "select yingshua from T_fixPRO where id='" + textBoxFixId.Text + "'";
            yinshuaQuery = databaseexe.getTopselect(yinshuaQuery, "yingshua");
            string zhanjiaoQuery = "select zhanjiao from T_fixPRO where id='" + textBoxFixId.Text + "'";
            zhanjiaoQuery = databaseexe.getTopselect(zhanjiaoQuery, "zhanjiao");
            string dadingQuery = "select dading from T_fixPRO where id ='" + textBoxFixId.Text + "'";
            dadingQuery = databaseexe.getTopselect(dadingQuery, "dading");
            if (yinshuaQuery.Equals("true"))
            {

                checkBox1.Checked = true;
            }
            if (zhanjiaoQuery.Equals("true"))
            {
                checkBox2.Checked = true;
            }
            if (dadingQuery.Equals("true"))
            {
                checkBox3.Checked = true;

            }
        }

        public DataGridViewRow dgvr;

        public void getValue()
        {
            textBoxFixId.Text = dgvr.Cells[0].Value.ToString();
            textBoxProductName.Text = dgvr.Cells[1].Value.ToString();
            textBoxTypeNAME.Text = dgvr.Cells[2].Value.ToString();
            textBoxMaterialName.Text = dgvr.Cells[3].Value.ToString();
            textBoxLength.Text = dgvr.Cells[4].Value.ToString();
            textBoxWide.Text = dgvr.Cells[5].Value.ToString();
            textBoxHeight.Text = dgvr.Cells[6].Value.ToString();
            textBoxUnit.Text = dgvr.Cells[7].Value.ToString();
            textBoxPrice.Text = dgvr.Cells[8].Value.ToString();
            
        

        }

        public frmFixAdd()
        {
            InitializeComponent();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string FixID = textBoxFixId.Text.Trim();
                string CusID = textBoxClientID.Text.Trim();
                string ProductName = textBoxProductName.Text.Trim();
                string typeId = comboBoxTypeID.Text.Trim();
                string TypeName = textBoxTypeNAME.Text.Trim();
                string unit = textBoxUnit.Text.Trim();
                string materialID = comboBoxMaterialID.Text.Trim();
                string materialName = textBoxMaterialName.Text.Trim();
                string Plength = textBoxLength.Text.Trim();
                string Pwide = textBoxWide.Text.Trim();
                string Pheight = textBoxHeight.Text.Trim();
                string quantity = textBoxQuantity.Text.Trim();
                string memo = textBoxMemo.Text.Trim();
                string price = textBoxPrice.Text.Trim();
                Boolean yinshua = checkBox1.Checked;
                Boolean zhanjiao = checkBox2.Checked;
                Boolean dading = checkBox3.Checked;
                string MidQuery = "select ID from T_MATERIAL where materialid ='" + materialID + "'";
                databaseexe databaseexe = new databaseexe();
                string id = databaseexe.getTopselect(MidQuery, "ID");
                string sql = "update T_FixPRO set typeId='" + typeId + "',productName ='" + ProductName + "',productType='" + TypeName +"',materialId='"+id+ "',MaterialName='" + materialName + "',Plength='" + Plength + "',pwide='" + Pwide + "',pheight='" + Pheight + "',unit='" + unit + "',quantity='" + quantity+ "',price='" + price + "',memo='" + memo +  "'where Id='" + FixID + "'";
                dbexe.sqlcmd(sql);
                
                if (yinshua.Equals(true))
                {
                    string sql2 = "update T_fixPRO set yingshua ='true' where id='" + FixID + "'";
                    dbexe.sqlcmd(sql2);

                }
                if (zhanjiao.Equals(true))
                {
                    string sql3 = "update T_fixPRO set zhanjiao ='true' where id='" + FixID + "'";
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
                MessageBox.Show("数据保存成功!");
          

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           
               
        }
        databaseexe dbexe = new databaseexe();
        private void frmFixAdd_Load(object sender, EventArgs e)
        {
            /*string QuantityQuery = "select quantity from T_fixPRO";
            databaseexe dbexe = new databaseexe();
            DataTable de1 =
                dbexe.getdataset(QuantityQuery, "T_fixPRO").Tables[0];
            for (int i = 0; i < de1.Rows.Count; i++)
            {
                DataRow dc = de1.Rows[i];
                textBoxQuantity.Text = dc["quantity"].ToString();

            }*/
            textBoxQuantity.Text = Quantity;
            string sql2 = "select ID from T_ProductType";
            DataTable db =
            dbexe.getdataset(sql2, " T_ProductType").Tables[0];
            
            for (int i = 0; i < db.Rows.Count; i++)
            {
                DataRow da = db.Rows[i];
                comboBoxTypeID.Items.Add(da["id"]);

            }

            if (db.Rows.Count > 0)
            {
                //comboBoxTypeID.SelectedIndex = -1;

            }

            string sql3 = "select typeName from T_ProductType where id='" + comboBoxTypeID.Text.ToString() + "'";
            DataTable dz =
                dbexe.getdataset(sql3, "T_ProductType").Tables[0];

            for (int i = 0; i < dz.Rows.Count; i++)
            {
                DataRow dc = dz.Rows[i];
                textBoxTypeNAME.Text = dc["typeName"].ToString();

            }
            string sql4 = "select MaterialId from T_material";
            DataTable dk =
            dbexe.getdataset(sql4, " T_Material").Tables[0];

            for (int i = 0; i < dk.Rows.Count; i++)
            {
                DataRow da = dk.Rows[i];
                comboBoxMaterialID.Items.Add(da["materialID"]);

            }

            if (db.Rows.Count > 0)
            {
                comboBoxMaterialID.SelectedIndex = -1;

            }

            string sql5 = "select materialName from T_material where materialid='" + comboBoxMaterialID.Text.ToString() + "'";
            DataTable dm =
                dbexe.getdataset(sql5, "T_material").Tables[0];

            for (int i = 0; i < dm.Rows.Count; i++)
            {
                DataRow dc = dm.Rows[i];
                textBoxMaterialName.Text = dc["materialname"].ToString();

            }
            
            
            textBoxClientID.Text = clientID.ToString();
            try
            {
                string sql = "select CusShort from T_Customer where Cusid ='" + textBoxClientID.Text.Trim() + "'";

                DataTable de =
                    dbexe.getdataset(sql, "T_customer").Tables[0];
                for (int i = 0; i < de.Rows.Count; i++)
                {
                    DataRow dc = de.Rows[i];
                    textBoxClientShort.Text = dc["CusShort"].ToString();
                }
                

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

        private void comboBoxTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select TypeName from T_productType where id='" + comboBoxTypeID.Text.ToString() + "'";
                DataTable dl =
                    dbexe.getdataset(sql, "T_productType").Tables[0];

                for (int i = 0; i < dl.Rows.Count; i++)
                {
                    DataRow dc = dl.Rows[i];
                    textBoxTypeNAME.Text = dc["TypeName"].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxMaterialID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select materialName from T_material where materialID='" + comboBoxMaterialID.Text.ToString() + "'";
                DataTable dl =
                    dbexe.getdataset(sql, "T_material").Tables[0];

                for (int i = 0; i < dl.Rows.Count; i++)
                {
                    DataRow dc = dl.Rows[i];
                    textBoxMaterialName.Text = dc["materialName"].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            //this.buttonPair.Enabled = true;

            try
            {

                string CusID = textBoxClientID.Text.Trim();
                string ProductName = textBoxProductName.Text.Trim();
                string typeId = comboBoxTypeID.Text.Trim();
                string TypeName = textBoxTypeNAME.Text.Trim();
                string unit = textBoxUnit.Text.Trim();
                string materialID = comboBoxMaterialID.Text.Trim();
                string materialName = textBoxMaterialName.Text.Trim();
                string Plength = textBoxLength.Text.Trim();
                string Pwide = textBoxWide.Text.Trim();
                string Pheight = textBoxHeight.Text.Trim();
                string quantity = textBoxQuantity.Text.Trim();
                string memo = textBoxMemo.Text.Trim();
                string price = textBoxPrice.Text.Trim();
                Boolean yinshua = checkBox1.Checked;
                Boolean zhanjiao = checkBox2.Checked;
                Boolean dading = checkBox3.Checked;
                string MidQuery = "select ID from T_MATERIAL where materialid ='" + materialID + "'";
                databaseexe databaseexe = new databaseexe();
                string id = databaseexe.getTopselect(MidQuery, "ID");
                //string sql = "insert into T_fixbox (cusID,productname,producttype,materialname,plength,pwide,pheight,unit,quantity,price,memo) values

                string sql = "insert into T_fixPRO (cusID,productname,typeID,producttype,materialid,materialname,plength,pwide,pheight,unit,quantity,memo,price) values ('" + CusID + "','" + ProductName + "','"+typeId+"','" + TypeName + "','" +id+"','" + materialName + "','" + Plength + "','" + Pwide + "','" + Pheight + "','" + unit + "','" + quantity + "','" + memo + "','"+price+ "')";


                /*string sql = "update T_Customer set CusShort='" + CusShort + "',CusName='" + CusName + "',CusTelephone='" + CusTel + "',CusFax='" + CusFax + "',CusAdress='" + CusAdress + "',CusPerson='" + CusPerson + "',CusBank='" + CusBank + "',CusAccount='" + CusAccount + "',CusMemo='" + CusMemo + "'where CusId='" + CusId + "'";*/
                dbexe.sqlcmd(sql);
                string sql1 = "select  top 1 id from T_FixPRO order by id DESC ";
                databaseexe databaseexe2 = new databaseexe();
                string newid = databaseexe2.getTopid(sql1);



                if (yinshua.Equals(true))
                {
                    string sql2 = "update T_fixPRO set yingshua ='true' where id='" + newid + "'";
                    dbexe.sqlcmd(sql2);

                }
                if (zhanjiao.Equals(true))
                {
                    string sql3 = "update T_fixPRO set zhanjiao ='true' where id='" + newid + "'";
                    dbexe.sqlcmd(sql3);


                }
                if (dading.Equals(true))
                {
                    string sql4 = "update T_fixPRO set dading ='true' where id='" + newid + "'";
                    dbexe.sqlcmd(sql4);

                }
                MessageBox.Show("数据保存成功!");

                string sql5 = "select  top 1 id from T_FixPRO order by id DESC ";
                databaseexe databaseexe3 = new databaseexe();
                textBoxFixId.Text= databaseexe2.getTopid(sql5);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.No)
            {
                return;

            }
            else
            {
                string ID = textBoxFixId.Text.ToString();
                string sql = "delete from T_fixPRO where Id='" + ID + "'";
                string sql2="delete from T_fixpro where fatherid='"+ID+"'";
                dbexe.sqlcmd(sql);
                dbexe.sqlcmd(sql2);
                MessageBox.Show("数据删除成功!");

            }
        }
        string mainId,ClientId,ClientName;

        private void buttonprice_Click(object sender, EventArgs e)
        {
            try
            {
                string length = textBoxLength.Text.Trim();
            string wide = textBoxWide.Text.Trim();
            string height = textBoxHeight.Text.Trim();
            AutoCount autoCount = new AutoCount();
           textBoxPrice.Text= autoCount.priceCount(length,wide,height);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void buttonPairSearch_Click(object sender, EventArgs e)
        {
            string Fatherid = textBoxFixId.Text.Trim();
               frmPairList frmsub = new frmPairList(Fatherid);
            frmsub.Show();
        }

        private void buttonPair_Click(object sender, EventArgs e)
        {
            mainId = textBoxFixId.Text.Trim();
            clientID = textBoxClientID.Text.Trim();
            ClientName = textBoxClientShort.Text.Trim();

            


            frmFixPair frmsub = new frmFixPair( mainId,clientID,ClientName);

            frmsub.Show();
        }
    }
}
