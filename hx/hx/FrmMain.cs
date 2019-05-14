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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabelTime.Text = DateTime.Now.ToString();
                toolStripStatusLabelName.Text = dataValue.StaffName.ToString();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void 基础信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier frmSupplier = new frmSupplier();
            frmSupplier.Show();
        }


        private void toolStripButtonManuf_Click(object sender, EventArgs e)
        {
            menuStripManuf.Visible = true;
            menuStripBasic.Visible = false;
            menuStripSale.Visible = false;
            menuStripPurchase.Visible = false;
            menuStripFinance.Visible = false;
            menuStripFix.Visible = false;
            panelBasic.Visible = false;
            panelSale.Visible = false;
            panelManuf.Visible = true;
            panelPurchase.Visible = false;
            panelStock.Visible = false;
            panelFinance.Visible = false;
            panelFix.Visible = false;

        }

        private void toolStripButtonBasic_Click(object sender, EventArgs e)
        {
           
            menuStripBasic.Visible = true;
            menuStripSale.Visible = false;
            menuStripManuf.Visible = false;
            menuStripPurchase.Visible = false;
            menuStripStock.Visible = false;
            menuStripFinance.Visible = false;
            menuStripFix.Visible = false;
            panelBasic.Visible = true;
            panelSale.Visible = false;
            panelManuf.Visible = false;
            panelPurchase.Visible = false;
            panelStock.Visible = false;
            panelFinance.Visible = false;
            panelFix.Visible = false;
        }

        private void toolStripButtonSale_Click(object sender, EventArgs e)
        {
            menuStripSale.Visible = true;
            menuStripBasic.Visible = false;
            menuStripManuf.Visible = false;
            menuStripPurchase.Visible = false;
            menuStripStock.Visible = false;
            menuStripFinance.Visible = false;
            menuStripFix.Visible = false;
            panelBasic.Visible = false;
            panelSale.Visible = true;
            panelManuf.Visible = false;
            panelPurchase.Visible = false;
            panelStock.Visible = false;
            panelFinance.Visible = false;
            panelFix.Visible = false;

        }

        private void toolStripButtonPurchase_Click(object sender, EventArgs e)
        {
            menuStripPurchase.Visible = true;
            menuStripManuf.Visible = false;
            menuStripSale.Visible = false;
            menuStripBasic.Visible = false;
            menuStripStock.Visible = false;
            menuStripFinance.Visible = false;
            menuStripFix.Visible = false;
            panelPurchase.Visible = true;
            panelBasic.Visible = false;
            panelSale.Visible = false;
            panelManuf.Visible = false;
            panelStock.Visible = false;
            panelFinance.Visible = false;
            panelFix.Visible = false;
        }

        private void toolStripButtonStock_Click(object sender, EventArgs e)
        {
            menuStripStock.Visible = true;
            menuStripPurchase.Visible = false;
            menuStripManuf.Visible = false;
            menuStripSale.Visible = false;
            menuStripBasic.Visible = false;
            menuStripFinance.Visible = false;
            menuStripFix.Visible = false;
            panelPurchase.Visible = false;
            panelStock.Visible = true;
            panelBasic.Visible = false;
            panelSale.Visible = false;
            panelManuf.Visible = false;
            panelFinance.Visible = false;
            panelFix.Visible = false;

        }

        private void toolStripButtonFinance_Click(object sender, EventArgs e)
        {
            menuStripFinance.Visible = true;
            menuStripStock.Visible = false;
            menuStripPurchase.Visible = false;
            menuStripManuf.Visible = false;
            menuStripSale.Visible = false;
            menuStripBasic.Visible = false;
            menuStripFix.Visible = false;
            panelBasic.Visible = false;
            panelSale.Visible = false;
            panelManuf.Visible = false;
            panelPurchase.Visible = false;
            panelStock.Visible = false;
            panelFinance.Visible = true;
            panelFix.Visible = false;
        }

       /* private void toolStripButtonFix_Click(object sender, EventArgs e)
        {
            menuStripFix.Visible = true;
            menuStripFinance.Visible = false;
            menuStripStock.Visible = false;
            menuStripPurchase.Visible = false;
            menuStripManuf.Visible = false;
            menuStripSale.Visible = false;
            menuStripBasic.Visible = false;
            panelBasic.Visible = false;
            panelSale.Visible = false;
            panelManuf.Visible = false;
            panelPurchase.Visible = false;
            panelStock.Visible = false;
            panelFinance.Visible = false;
            panelFix.Visible = true;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("您确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.No)
                return;
            //Application.Exit();
            this.Close();
            FrmLogin frmlog = new FrmLogin();
            frmlog.Show();
        }*/

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Pen pen1 = new Pen(Color.Gray, 1);
            pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen1.DashPattern = new float[] { 4f, 2f };
            e.Graphics.DrawRectangle(pen1, 0, 0, this.panel1.Width - 1,this.panel1.Height-1);
        }

        private void toolStripButtonLeave_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("您确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.No)
                return;
            Application.Exit();
            this.Close();
            /*FrmLogin frmlog = new FrmLogin();
            frmlog.Show();*/
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            /*Pen pen3 = new Pen(Color.Gray, 1);
            pen3.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen3.DashPattern = new float[] { 4f, 2f };
            e.Graphics.DrawRectangle(pen3, 0, 0, this.panel3.Width - 1, this.panel3.Height - 1);*/
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen2 = new Pen(Color.Gray, 1);
            pen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen2.DashPattern = new float[] { 4f, 2f };
            e.Graphics.DrawRectangle(pen2, 0, 0, this.panel2.Width - 1, this.panel2.Height - 1);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Pen pen5 = new Pen(Color.Gray, 1);
            pen5.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen5.DashPattern = new float[] { 4f, 2f };
            e.Graphics.DrawRectangle(pen5, 0, 0, this.panel5.Width - 1, this.panel5.Height - 1);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Pen pen6 = new Pen(Color.Gray, 1);
            pen6.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen6.DashPattern = new float[] { 4f, 2f };
            e.Graphics.DrawRectangle(pen6, 0, 0, this.panel6.Width - 1, this.panel6.Height - 1);
        }

        private void panelFinance_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonFix_Click_1(object sender, EventArgs e)
        {
            menuStripFix.Visible = true;
            menuStripFinance.Visible = false;
            menuStripStock.Visible = false;
            menuStripPurchase.Visible = false;
            menuStripManuf.Visible = false;
            menuStripSale.Visible = false;
            menuStripBasic.Visible = false;
            panelBasic.Visible = false;
            panelSale.Visible = false;
            panelManuf.Visible = false;
            panelPurchase.Visible = false;
            panelStock.Visible = false;
            panelFinance.Visible = false;
            panelFix.Visible = true;
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            
            frmSupplier frmSupplier = new frmSupplier();
            frmSupplier.Show();
        }

        private void buttonMaterial_Click(object sender, EventArgs e)
        {
            frmMaterial frmMaterial = new frmMaterial();
            frmMaterial.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            frmClient frmClient = new frmClient();
            frmClient.Show();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            frmProductType frmProductType = new frmProductType();
            frmProductType.Show();
        }

        private void 纸板信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductType frmProductType = new frmProductType();
            frmProductType.Show();
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void buttonFixBox_Click(object sender, EventArgs e)
        {
            frmFixProduct frmFixProduct = new frmFixProduct();
            frmFixProduct.Show();
        }

        private void buttonNewSale_Click(object sender, EventArgs e)
        {
            frmDingdan frmSub = new frmDingdan();
            frmSub.Show();
            
        }

        private void 客户信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient frmClient = new frmClient();
            frmClient.Show();
        }

        private void 纸箱信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterial frmMaterial = new frmMaterial();
            frmMaterial.Show();
        }

        private void toolStripStatusLabelTime_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchSale_Click(object sender, EventArgs e)
        {
            frmManuManage3 frmsub = new frmManuManage3();
            frmsub.Show();
            /*frmsub.buttonModify.Enabled = false;
            frmsub.buttonRefresh.Enabled = false;
            frmsub.buttonSaveNew.Enabled = false;*/


        }

        private void buttonManuOrder_Click(object sender, EventArgs e)
        {
            frmManuManage3 frmsub = new frmManuManage3();
            frmsub.Show();
        }

        private void buttonProductIn_Click(object sender, EventArgs e)
        {
            frmProductIn3 frmsub = new frmProductIn3();
            frmsub.Show();
        }

        private void panelFix_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonPorder_Click(object sender, EventArgs e)
        {
            frmPurchaseManage4 frmsub = new frmPurchaseManage4();
            frmsub.Show();
        }

        private void buttonMaterialIn_Click(object sender, EventArgs e)
        {
            frmMaterialIn4 frmsub = new frmMaterialIn4();
            frmsub.Show();
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            frmDeliveryManage5 frmsub = new frmDeliveryManage5();
            frmsub.Show();
        }

        private void buttonIden_Click(object sender, EventArgs e)
        {

            frmUserManage7 frmsub = new frmUserManage7();
            frmsub.Show();
        }

        private void buttonMaterialPlan_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPurchasePlan_Click(object sender, EventArgs e)
        {
            frmBom3 frmsub = new frmBom3();
            frmsub.Show();
        }

        private void 创建销售订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDingdan frmsub = new frmDingdan();
            frmsub.Show();
        }

        private void buttonMaterialStock_Click(object sender, EventArgs e)
        {
            frmMatStock5 frmsub = new frmMatStock5();
            frmsub.Show();
        }

        private void buttonProductStock_Click(object sender, EventArgs e)
        {
            frmProStock5 frmsub = new frmProStock5();
            frmsub.Show();
        }

        private void 填写订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 未生成生产单订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 查询订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 填制生产单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManuManage3 frmsub = new frmManuManage3();
            frmsub.Show();
        }

        private void 物料需求ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBom3 frmsub = new frmBom3();
            frmsub.Show();
        }

        private void 成品入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductIn3 frmsub = new frmProductIn3();
            frmsub.Show();
        }

        private void 审核处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatStock5 frmsub = new frmMatStock5();
            frmsub.Show();
        }

        private void 库存管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProStock5 frmsub = new frmProStock5();
            frmsub.Show();
        }

        private void 成品送货单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeliveryManage5 frmsub = new frmDeliveryManage5();
            frmsub.Show();
        }

        private void 制定采购计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseManage4 frmsub = new frmPurchaseManage4();
            frmsub.Show();
        }

        private void 填制纸板入库单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterialIn4 frmsub = new frmMaterialIn4();
            frmsub.Show();
        }

        private void 用户权限设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManage7 frmsub = new frmUserManage7();
            frmsub.Show();
        }
    }
}
