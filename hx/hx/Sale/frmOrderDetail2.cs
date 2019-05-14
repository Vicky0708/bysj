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
    public partial class frmOrderDetail2 : Form
    {
        public frmOrderDetail2(DataGridViewRow dgvr1)
        {
            InitializeComponent();
            dgvr = dgvr1;
            getValue();
        


        }

        public DataGridViewRow dgvr;
        public void getValue()
        {
            textBoxOrderId.Text = dgvr.Cells[1].Value.ToString();
            textBoxId.Text = dgvr.Cells[2].Value.ToString();
            textBoxProductName.Text = dgvr.Cells[3].Value.ToString();
            textBoxTypeNAME.Text = dgvr.Cells[4].Value.ToString();
            textBoxMaterialName.Text = dgvr.Cells[5].Value.ToString();
            textBoxLength.Text = dgvr.Cells[6].Value.ToString();
            textBoxWide.Text = dgvr.Cells[7].Value.ToString();
            textBoxHeight.Text = dgvr.Cells[8].Value.ToString();


        }
        public frmOrderDetail2()
        {
            InitializeComponent();
        }

        private void textBoxTypeNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        databaseexe databaseexe = new databaseexe();
        private void frmOrderDetail2_Load(object sender, EventArgs e)
        {
            //float.Parse(length)
            
            string typeid = "select typeid from T_allsale where id ='" + textBoxId.Text + "'";
            textBoxTypeid.Text = databaseexe.getTopselect(typeid, "typeid");

            string unit = "select unit from T_allsale where id ='" + textBoxId.Text + "'";
            textBoxUnit.Text = databaseexe.getTopselect(unit, "unit");


            string deliveryDateQuery = "select deliverytime from T_allsale where id ='" + textBoxId.Text + "'";
            textBoxDeliveryTime.Text = databaseexe.getTopselect(deliveryDateQuery, "deliverytime");

            string quantity = "select orderquantity from T_allsale where id ='" + textBoxId.Text + "'";
            textBoxQuantity.Text = databaseexe.getTopselect(quantity, "orderquantity");
            string unitPrice = "select price from T_allsale where id ='" + textBoxId.Text + "'";
            textBoxunitPrice.Text = databaseexe.getTopselect(unitPrice, "price");
            string materialid = "select materialid from T_allsale where id ='" + textBoxId.Text + "'";
            textBoxMaterialId.Text = databaseexe.getTopselect(materialid, "materialid");
            string yinshuaQuery = "select yingshua from T_allsale where id='" + textBoxId.Text + "'";
            yinshuaQuery = databaseexe.getTopselect(yinshuaQuery, "yingshua");
            string zhanjiaoQuery = "select zhanjiao from T_allsale where id='" + textBoxId.Text + "'";
            zhanjiaoQuery = databaseexe.getTopselect(zhanjiaoQuery, "zhanjiao");
            string dadingQuery = "select dading from T_allsale where id ='" + textBoxId.Text + "'";
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
            try
            {textBoxPrice.Text = (float.Parse(textBoxunitPrice.Text) *float.Parse( textBoxQuantity.Text)).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
