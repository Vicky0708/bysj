using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hx
{
    

    public partial class FrmLogin : Form
    {
        int i = 1;
        int k = 9;
       
        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            g.DrawPath(p, gp);
         
            gp.Dispose();

        }
        public FrmLogin()
        {
            InitializeComponent();
        }
        string yhm,mm,yzm;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            yhm = mm=yzm= "";
            // PurchaseGenerator purchaseGenerator = new PurchaseGenerator();
            //MessageBox.Show(purchaseGenerator.purchaseGenerator());
           
            


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.FromArgb(30, 40, 60, 122);
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
    
    {
            //panel2.BackColor = System.Drawing.Color.FromArgb(40, 40, 60, 122);
            Graphics v = e.Graphics;
 
           DrawRoundRect(v, Pens.White, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
            base.OnPaint(e);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
       
        }
          private void textBox2_Enter_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
            textBox2.PasswordChar = '*';
      
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.ForeColor = Color.Black;
     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            btnOK.Enabled = true;
            timer2.Enabled = false;
            i = 1;
            k = 9;
            btnOK.Text = "登录";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnOK.Text = "登录（" + k.ToString() + ")";
            k--;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (i > 2)
            {
                MessageBox.Show("您已经密码错误了2次，不能登录");
                textBox1.Clear();
                textBox2.Clear();
                timer1.Enabled = true;
                btnOK.Enabled = false;
                timer2.Enabled = true;
                return;
            }
            string yhm = textBox1.Text.ToString().Trim();
            string mm = textBox2.Text.ToString().Trim();
            string yzm = textBox3.Text.ToString().Trim();
            dataValue.UserName = yhm;
            dataValue.Password = mm;
            string sql2 = "select * from T_member where jobno='" + yhm + "' ";
            databaseexe databaseexe1 = new databaseexe();
            dataValue.StaffName = databaseexe1.getTopName(sql2);
            if (yhm == "")
            {
                MessageBox.Show("用户名不能为空！");
            }
            else
            {
                Connstr connstr = new Connstr();
                SqlConnection conn = connstr.getcon();
                string sql = "select * from T_user where username='" + yhm + "' and password='" + mm + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("登陆成功");
                    databaseexe dbexe = new databaseexe();
                    string sql1 = "select jobname from T_Member where jobNo='" + yhm+ "'";
                    DataTable de =
                        dbexe.getdataset(sql1, "T_member").Tables[0];
                    for (int i = 0; i < de.Rows.Count; i++)
                    {
                        DataRow dc = de.Rows[i];
                        dataValue.StaffName= dc["jobname"].ToString();

                    }
                    FrmMain mainform = new FrmMain();
                    mainform.Show();
                    this.Hide();
               
                    
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                    textBox1.Clear();
                    textBox2.Clear();
                    i++;

                }






                }
        }

      

       
    }


    
    


    
}
