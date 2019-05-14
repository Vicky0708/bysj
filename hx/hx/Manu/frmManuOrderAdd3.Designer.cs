namespace hx
{
    partial class frmManuOrderAdd3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManuOrderAdd3));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxManuPerson = new System.Windows.Forms.TextBox();
            this.textBoxManuId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textBoxCusshort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCusid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOrderdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDeliveryDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSaleID = new System.Windows.Forms.TextBox();
            this.ManudataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManudataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 88;
            this.label4.Text = "开单员";
            // 
            // textBoxManuPerson
            // 
            this.textBoxManuPerson.Enabled = false;
            this.textBoxManuPerson.Location = new System.Drawing.Point(156, 117);
            this.textBoxManuPerson.Name = "textBoxManuPerson";
            this.textBoxManuPerson.Size = new System.Drawing.Size(180, 25);
            this.textBoxManuPerson.TabIndex = 87;
            this.textBoxManuPerson.TextChanged += new System.EventHandler(this.textBoxManuPerson_TextChanged);
            // 
            // textBoxManuId
            // 
            this.textBoxManuId.Enabled = false;
            this.textBoxManuId.Location = new System.Drawing.Point(156, 77);
            this.textBoxManuId.Name = "textBoxManuId";
            this.textBoxManuId.Size = new System.Drawing.Size(180, 25);
            this.textBoxManuId.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "生产单号";
            // 
            // buttonChoose
            // 
            this.buttonChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChoose.Image = ((System.Drawing.Image)(resources.GetObject("buttonChoose.Image")));
            this.buttonChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChoose.Location = new System.Drawing.Point(12, 12);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(109, 42);
            this.buttonChoose.TabIndex = 140;
            this.buttonChoose.Text = "订单查看";
            this.buttonChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReturn.Image = ((System.Drawing.Image)(resources.GetObject("buttonReturn.Image")));
            this.buttonReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReturn.Location = new System.Drawing.Point(247, 12);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(92, 42);
            this.buttonReturn.TabIndex = 139;
            this.buttonReturn.Text = "     返回";
            this.buttonReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // textBoxCusshort
            // 
            this.textBoxCusshort.Enabled = false;
            this.textBoxCusshort.Location = new System.Drawing.Point(763, 77);
            this.textBoxCusshort.Name = "textBoxCusshort";
            this.textBoxCusshort.Size = new System.Drawing.Size(130, 25);
            this.textBoxCusshort.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 141;
            this.label1.Text = "客户编码";
            // 
            // textBoxCusid
            // 
            this.textBoxCusid.Enabled = false;
            this.textBoxCusid.Location = new System.Drawing.Point(691, 77);
            this.textBoxCusid.Name = "textBoxCusid";
            this.textBoxCusid.Size = new System.Drawing.Size(66, 25);
            this.textBoxCusid.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 145;
            this.label3.Text = "订单日期";
            // 
            // textBoxOrderdate
            // 
            this.textBoxOrderdate.Enabled = false;
            this.textBoxOrderdate.Location = new System.Drawing.Point(418, 117);
            this.textBoxOrderdate.Name = "textBoxOrderdate";
            this.textBoxOrderdate.Size = new System.Drawing.Size(180, 25);
            this.textBoxOrderdate.TabIndex = 144;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 147;
            this.label5.Text = "交货日期";
            // 
            // textBoxDeliveryDate
            // 
            this.textBoxDeliveryDate.Enabled = false;
            this.textBoxDeliveryDate.Location = new System.Drawing.Point(691, 117);
            this.textBoxDeliveryDate.Name = "textBoxDeliveryDate";
            this.textBoxDeliveryDate.Size = new System.Drawing.Size(202, 25);
            this.textBoxDeliveryDate.TabIndex = 146;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 148;
            this.label6.Text = "订单号";
            // 
            // textBoxSaleID
            // 
            this.textBoxSaleID.Enabled = false;
            this.textBoxSaleID.Location = new System.Drawing.Point(418, 77);
            this.textBoxSaleID.Name = "textBoxSaleID";
            this.textBoxSaleID.Size = new System.Drawing.Size(180, 25);
            this.textBoxSaleID.TabIndex = 149;
            // 
            // ManudataGridView1
            // 
            this.ManudataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ManudataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ManudataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ManudataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ManudataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ManudataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ManudataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.ManudataGridView1.Location = new System.Drawing.Point(2, 199);
            this.ManudataGridView1.Name = "ManudataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ManudataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ManudataGridView1.RowTemplate.Height = 27;
            this.ManudataGridView1.Size = new System.Drawing.Size(1026, 223);
            this.ManudataGridView1.TabIndex = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 151;
            this.label7.Text = "备注";
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Enabled = false;
            this.textBoxMemo.Location = new System.Drawing.Point(156, 157);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new System.Drawing.Size(737, 25);
            this.textBoxMemo.TabIndex = 152;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(127, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 42);
            this.button2.TabIndex = 163;
            this.button2.Text = "预览打印";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmManuOrderAdd3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 431);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxMemo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ManudataGridView1);
            this.Controls.Add(this.textBoxSaleID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDeliveryDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOrderdate);
            this.Controls.Add(this.textBoxCusid);
            this.Controls.Add(this.textBoxCusshort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxManuPerson);
            this.Controls.Add(this.textBoxManuId);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManuOrderAdd3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生产单";
            this.Load += new System.EventHandler(this.frmManuOrderAdd3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManudataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxManuPerson;
        public System.Windows.Forms.TextBox textBoxManuId;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxCusshort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCusid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOrderdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDeliveryDate;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxSaleID;
        private System.Windows.Forms.DataGridView ManudataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.Button button2;
    }
}