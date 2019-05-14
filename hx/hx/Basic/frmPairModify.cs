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
    public partial class frmPairModify : Form
    {
        public frmPairModify(DataGridViewRow dgvr1)
        {
            InitializeComponent();
            dgvr = dgvr1;
            getValue();


        }
        databaseexe databaseexe = new databaseexe();
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
            string CusIDQuery = "select Cusid from T_fixPRO where id ='" + textBoxFixId.Text.Trim() + "'";
            textBoxClientID.Text = databaseexe.getTopselect(CusIDQuery, "cusid");
            string CusNAMEQuery = "select Cusshort from T_Customer where Cusid ='" + textBoxClientID.Text.Trim() + "'";
            textBoxClientShort.Text = databaseexe.getTopselect(CusNAMEQuery, "cusshort");
            string Fatherid= "select fatherid from T_fixPRO where id ='" + textBoxFixId.Text.Trim() + "'";
            textBoxFixMaiNId.Text = databaseexe.getTopselect(Fatherid, "fatherid");
            string memo = "select memo from T_fixPRO where id ='" + textBoxFixId.Text.Trim() + "'";
            textBoxMemo.Text = databaseexe.getTopselect(memo, "memo");

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

        public frmPairModify()
        {
            InitializeComponent();
        }
        databaseexe dbexe = new databaseexe();
        private void frmPairModify_Load(object sender, EventArgs e)
        {

            string typeid = "select typeid from T_fixPRO where producttype ='" + textBoxTypeNAME.Text.Trim() + "'";
           comboBoxTypeID.Text = databaseexe.getTopselect(typeid, "typeid");

            string materialid = "select materialid from T_material where materialName ='" + textBoxMaterialName.Text.Trim() + "'";
            comboBoxMaterialID.Text = databaseexe.getTopselect(materialid, "materialid");
            string quantity = "select quantity from T_fixpro where id ='" + textBoxFixId.Text.Trim() + "'";
            textBoxQuantity.Text = databaseexe.getTopselect(quantity, "quantity");

            string PriceQuery = "select price from T_fixpro where id ='" + textBoxFixId.Text + "'";
            textBoxPrice.Text = databaseexe.getTopselect(PriceQuery, "price");

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
                string sql = "update T_FixPRO set typeId='" + typeId + "',ProductName ='" + ProductName + "',productType='" + TypeName + "',materialId='" + id + "',MaterialName='" + materialName + "',Plength='" + Plength + "',Pwide='" + Pwide + "',Pheight='" + Pheight + "',unit='" + unit + "',quantity='" + quantity + "',price='" + price + "',memo='" + memo + "'where Id='" + FixID + "'";
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
    }
}
