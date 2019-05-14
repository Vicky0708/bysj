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
    public partial class frmFixPair : Form
    {
        
       
            string mainId,clientId,clientName;
        public frmFixPair(string id,string Cid,string Nid)
        {
            InitializeComponent();
            mainId = id;
            clientId = Cid;
            clientName = Nid;
        }
        /*databaseexe databaseexe=new databaseexe();
        public frmFixPair(DataGridViewRow dgvr1)
        {
            InitializeComponent();
            dgvr = dgvr1;
            getValue();
            
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

        }*/

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            //frmFixAdd frmsub = new frmFixAdd();
            //frmsub.buttonPairSearch.Enabled = true;

            try
            {
                
                string CusID = textBoxClientID.Text.Trim();
                string FatherId = textBoxFixMaiNId.Text.Trim();
                string fittingName = textBoxProductName.Text.Trim();
                string typeId = comboBoxTypeID.Text.Trim();
                string TypeName = textBoxTypeNAME.Text.Trim();
                string unit = textBoxUnit.Text.Trim();
                string materialID = comboBoxMaterialID.Text.Trim();
                string materialName = textBoxMaterialName.Text.Trim();
                string Flength = textBoxLength.Text.Trim();
                string Fwide = textBoxWide.Text.Trim();
                string Fheight = textBoxHeight.Text.Trim();
                string quantity = textBoxQuantity.Text.Trim();
                string memo = textBoxMemo.Text.Trim();
                string price = textBoxPrice.Text.Trim();
                Boolean yinshua = checkBox1.Checked;
                Boolean zhanjiao = checkBox2.Checked;
                Boolean dading = checkBox3.Checked;
                //string sql = "insert into T_fixbox (cusID,productname,producttype,materialname,plength,pwide,pheight,unit,quantity,price,memo) values
                string MidQuery = "select ID from T_MATERIAL where materialid ='" + materialID + "'";
                databaseexe databaseexe = new databaseexe();
                string id = databaseexe.getTopselect(MidQuery, "ID");
                string sql = "insert into T_fixpro (CusId,productNAME,typeid,producttype,materialId,MaterialName,plength,pwide,pheight,unit,quantity,fatherid,memo,price) values ('" + CusID + "','" + fittingName + "','" + typeId + "','" + TypeName + "','" + id+ "','" + materialName + "','" + Flength + "','" + Fwide + "','" + Fheight + "','" +unit + "','" +quantity + "','" +FatherId + "','" +memo+ "','" +price+"')";


                /*string sql = "update T_Customer set CusShort='" + CusShort + "',CusName='" + CusName + "',CusTelephone='" + CusTel + "',CusFax='" + CusFax + "',CusAdress='" + CusAdress + "',CusPerson='" + CusPerson + "',CusBank='" + CusBank + "',CusAccount='" + CusAccount + "',CusMemo='" + CusMemo + "'where CusId='" + CusId + "'";*/
                dbexe.sqlcmd(sql);
                string sql1 = "select  top 1 id from T_fixpro order by id DESC ";
                databaseexe databaseexe2 = new databaseexe();
                string newid = databaseexe2.getTopid(sql1);



                if (yinshua.Equals(true))
                {
                    string sql2 = "update T_fixpro set yingshua ='true' where id='" + newid + "'";
                    dbexe.sqlcmd(sql2);

                }
                if (zhanjiao.Equals(true))
                {
                    string sql3 = "update T_fixpro set zhanjiao ='true' where id='" + newid + "'";
                    dbexe.sqlcmd(sql3);


                }
                if (dading.Equals(true))
                {
                    string sql4 = "update T_fixpro set dading ='true' where id='" + newid + "'";
                    dbexe.sqlcmd(sql4);

                }
                MessageBox.Show("数据保存成功!");

                string sql5 = "select  top 1 id from T_fixpro order by id DESC ";
                databaseexe databaseexe3 = new databaseexe();
                textBoxFixId.Text = databaseexe2.getTopid(sql5);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        databaseexe dbexe = new databaseexe();
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

        private void buttonprice_Click(object sender, EventArgs e)
        {
            try
            {
                string length = textBoxLength.Text.Trim();
                string wide = textBoxWide.Text.Trim();
                string height = textBoxHeight.Text.Trim();
                AutoCount autoCount = new AutoCount();
                textBoxPrice.Text = autoCount.priceCount(length, wide, height);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public frmFixPair()
        {
            InitializeComponent();
        }

        private void frmFixPair_Load(object sender, EventArgs e)
        {
            textBoxFixMaiNId.Text = mainId;
            textBoxClientID.Text = clientId;
            textBoxClientShort.Text = clientName;

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
        }
    }
}
