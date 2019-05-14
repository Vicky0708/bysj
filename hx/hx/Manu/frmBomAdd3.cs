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
    public partial class frmBomAdd3 : Form
    {
        public frmBomAdd3()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {

        }
        databaseexe dbexe = new databaseexe();
        private void frmBomAdd3_Load(object sender, EventArgs e)
        {
            string BomidQuery = "select top 1 bomid from t_bom order by bomid desc ";
            databaseexe databaseexe =new databaseexe();
            string Bomid = databaseexe.getTopselect(BomidQuery, "bomid");
            Bomid = (int.Parse(Bomid) + 1).ToString();
            textBoxBoid1.Text = Bomid;
            textBoxProId.Text = dataValue.Bomid;
            textBoxLength.Text = dataValue.Bomlength;
            textBoxWide.Text = dataValue.BomWide;
            textBoxHeight.Text = dataValue.Bomheight;
            string productid = textBoxProId.Text.Trim();
            string sql = "select productName from T_bomall where id ='" + productid + "'";
            DataTable de =
                dbexe.getdataset(sql, "T_bomall").Tables[0];
            for (int i = 0; i < de.Rows.Count; i++)
            {
                DataRow dc = de.Rows[i];
                textBoxProductName.Text = dc["productname"].ToString();
            }
            string sql1 = "select quantity from T_bomall where id ='" + productid + "'";
            DataTable da =
                dbexe.getdataset(sql1, "T_bomall").Tables[0];
            for (int i = 0; i < da.Rows.Count; i++)
            {
                DataRow dz = da.Rows[i];
                textBoxProQuantity.Text = dz["quantity"].ToString();
            }

            string sql4 = "select MaterialId from T_material";
            DataTable dk =
            dbexe.getdataset(sql4, " T_Material").Tables[0];

            for (int i = 0; i < dk.Rows.Count; i++)
            {
                DataRow dc = dk.Rows[i];
                BomNamecomboBox1.Items.Add(dc["materialID"]);

            }

            if (dk.Rows.Count > 0)
            {
                BomNamecomboBox1.SelectedIndex = -1;

            }

            string sql5 = "select materialName from T_material where materialid='" + BomNamecomboBox1.Text.ToString() + "'";
            DataTable dm =
                dbexe.getdataset(sql5, "T_material").Tables[0];

            for (int i = 0; i < dm.Rows.Count; i++)
            {
                DataRow dc = dm.Rows[i];
                textBoxBomname1.Text = dc["materialname"].ToString();

            }



        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string BomName = textBoxBomname1.Text.Trim();
            string proid = textBoxProId.Text.Trim();
            string bomsize = textBoxBomSize1.Text.Trim();
            string Unitquantity = textBoxQuantity1.Text.Trim();
            string BomUnit = textBoxUnit1.Text.Trim();
            string BomFrom = textBoxBomfrom1.Text.Trim();
            string materialid = BomNamecomboBox1.Text.Trim();

            string sql = "insert into T_bom ( bomname,bomsize,unitquantity,bomunit,bomfrom,proid,materialid) values ('" + BomName + "','"+bomsize+ "','"+Unitquantity+ "','"+BomUnit+ "','"+BomFrom+ "','"+proid+"','"+materialid+"')";
            dbexe.sqlcmd(sql);
            MessageBox.Show("数据添加成功!");
        }

        private void tableLayoutPanel1_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void BomNamecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select materialName from T_material where materialID='" +BomNamecomboBox1.Text.ToString() + "'";
                DataTable dl =
                    dbexe.getdataset(sql, "T_material").Tables[0];

                for (int i = 0; i < dl.Rows.Count; i++)
                {
                    DataRow dc = dl.Rows[i];
                    textBoxBomname1.Text = dc["materialName"].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
