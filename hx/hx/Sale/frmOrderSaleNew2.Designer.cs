namespace hx
{
    partial class frmOrderSaleNew2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderSaleNew2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCheckDate = new System.Windows.Forms.TextBox();
            this.buttonSaveNew = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFix = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOrderid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOderperson = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMultiColumnsClientid = new ComboBoxMultiColumns.ComboBoxMultiColumns();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCheckPerson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductdataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DeliveryTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Enabled = false;
            this.textBoxStatus.Location = new System.Drawing.Point(632, 110);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(158, 25);
            this.textBoxStatus.TabIndex = 108;
            this.textBoxStatus.Text = "待审";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 109;
            this.label8.Text = "状态";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(796, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 113;
            this.label10.Text = "交货日期";
            // 
            // textBoxCheckDate
            // 
            this.textBoxCheckDate.Enabled = false;
            this.textBoxCheckDate.Location = new System.Drawing.Point(869, 107);
            this.textBoxCheckDate.Name = "textBoxCheckDate";
            this.textBoxCheckDate.Size = new System.Drawing.Size(158, 25);
            this.textBoxCheckDate.TabIndex = 114;
            // 
            // buttonSaveNew
            // 
            this.buttonSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSaveNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveNew.Image")));
            this.buttonSaveNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveNew.Location = new System.Drawing.Point(12, 12);
            this.buttonSaveNew.Name = "buttonSaveNew";
            this.buttonSaveNew.Size = new System.Drawing.Size(92, 42);
            this.buttonSaveNew.TabIndex = 70;
            this.buttonSaveNew.Text = "新增";
            this.buttonSaveNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveNew.UseVisualStyleBackColor = true;
            this.buttonSaveNew.Click += new System.EventHandler(this.buttonSaveNew_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReturn.Image = ((System.Drawing.Image)(resources.GetObject("buttonReturn.Image")));
            this.buttonReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReturn.Location = new System.Drawing.Point(529, 12);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(92, 42);
            this.buttonReturn.TabIndex = 71;
            this.buttonReturn.Text = "     返回";
            this.buttonReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(208, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 42);
            this.buttonDelete.TabIndex = 72;
            this.buttonDelete.Text = "整单删除";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonFix
            // 
            this.buttonFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFix.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFix.Image = ((System.Drawing.Image)(resources.GetObject("buttonFix.Image")));
            this.buttonFix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFix.Location = new System.Drawing.Point(323, 12);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(102, 42);
            this.buttonFix.TabIndex = 73;
            this.buttonFix.Text = "固定箱";
            this.buttonFix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFix.UseVisualStyleBackColor = true;
            this.buttonFix.Click += new System.EventHandler(this.buttonFix_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCheck.Image = ((System.Drawing.Image)(resources.GetObject("buttonCheck.Image")));
            this.buttonCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheck.Location = new System.Drawing.Point(431, 12);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(92, 42);
            this.buttonCheck.TabIndex = 74;
            this.buttonCheck.Text = "审核";
            this.buttonCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 75;
            this.label2.Text = "订单号";
            // 
            // textBoxOrderid
            // 
            this.textBoxOrderid.Enabled = false;
            this.textBoxOrderid.Location = new System.Drawing.Point(83, 69);
            this.textBoxOrderid.Name = "textBoxOrderid";
            this.textBoxOrderid.Size = new System.Drawing.Size(121, 25);
            this.textBoxOrderid.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 77;
            this.label3.Text = "录入日期";
            // 
            // textBoxInDate
            // 
            this.textBoxInDate.Enabled = false;
            this.textBoxInDate.Location = new System.Drawing.Point(283, 71);
            this.textBoxInDate.Name = "textBoxInDate";
            this.textBoxInDate.Size = new System.Drawing.Size(118, 25);
            this.textBoxInDate.TabIndex = 78;
            this.textBoxInDate.TextChanged += new System.EventHandler(this.textBoxInDate_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 79;
            this.label4.Text = "开单员";
            // 
            // textBoxOderperson
            // 
            this.textBoxOderperson.Enabled = false;
            this.textBoxOderperson.Location = new System.Drawing.Point(465, 69);
            this.textBoxOderperson.Name = "textBoxOderperson";
            this.textBoxOderperson.Size = new System.Drawing.Size(88, 25);
            this.textBoxOderperson.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 87;
            this.label9.Text = "客户编码";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Enabled = false;
            this.textBoxClientName.Location = new System.Drawing.Point(210, 110);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(191, 25);
            this.textBoxClientName.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 98;
            this.label1.Text = "订单日期";
            // 
            // comboBoxMultiColumnsClientid
            // 
            this.comboBoxMultiColumnsClientid.DisplayMember = "客户编码";
            this.comboBoxMultiColumnsClientid.Location = new System.Drawing.Point(83, 112);
            this.comboBoxMultiColumnsClientid.Name = "comboBoxMultiColumnsClientid";
            this.comboBoxMultiColumnsClientid.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMultiColumnsClientid.TabIndex = 101;
            this.comboBoxMultiColumnsClientid.Text = "comboBoxMultiColumns1";
            this.comboBoxMultiColumnsClientid.SelectedIndexChanged += new System.EventHandler(this.comboBoxMultiColumnsClientid_SelectedIndexChanged);
            this.comboBoxMultiColumnsClientid.TextChanged += new System.EventHandler(this.comboBoxMultiColumnsClientid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 102;
            this.label5.Text = "备注";
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Location = new System.Drawing.Point(83, 157);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new System.Drawing.Size(944, 25);
            this.textBoxMemo.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 104;
            this.label6.Text = "审核人";
            // 
            // textBoxCheckPerson
            // 
            this.textBoxCheckPerson.Enabled = false;
            this.textBoxCheckPerson.Location = new System.Drawing.Point(465, 110);
            this.textBoxCheckPerson.Name = "textBoxCheckPerson";
            this.textBoxCheckPerson.Size = new System.Drawing.Size(88, 25);
            this.textBoxCheckPerson.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(796, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 106;
            this.label7.Text = "审核时间";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ProductdataGridView1
            // 
            this.ProductdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProductdataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductdataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProductdataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductdataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductdataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductdataGridView1.Location = new System.Drawing.Point(1, 208);
            this.ProductdataGridView1.Name = "ProductdataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductdataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductdataGridView1.RowTemplate.Height = 27;
            this.ProductdataGridView1.Size = new System.Drawing.Size(1026, 155);
            this.ProductdataGridView1.TabIndex = 110;
            this.ProductdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductdataGridView1_CellContentClick);
            // 
            // OrderdateTimePicker1
            // 
            this.OrderdateTimePicker1.Location = new System.Drawing.Point(632, 69);
            this.OrderdateTimePicker1.Name = "OrderdateTimePicker1";
            this.OrderdateTimePicker1.Size = new System.Drawing.Size(158, 25);
            this.OrderdateTimePicker1.TabIndex = 111;
            // 
            // DeliveryTimePicker2
            // 
            this.DeliveryTimePicker2.Location = new System.Drawing.Point(869, 67);
            this.DeliveryTimePicker2.Name = "DeliveryTimePicker2";
            this.DeliveryTimePicker2.Size = new System.Drawing.Size(158, 25);
            this.DeliveryTimePicker2.TabIndex = 112;
            // 
            // buttonModify
            // 
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonModify.Image = ((System.Drawing.Image)(resources.GetObject("buttonModify.Image")));
            this.buttonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModify.Location = new System.Drawing.Point(110, 12);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(92, 42);
            this.buttonModify.TabIndex = 69;
            this.buttonModify.Text = "修改";
            this.buttonModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // frmOrderSaleNew2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 375);
            this.Controls.Add(this.textBoxCheckDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeliveryTimePicker2);
            this.Controls.Add(this.OrderdateTimePicker1);
            this.Controls.Add(this.ProductdataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCheckPerson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMemo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMultiColumnsClientid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxOderperson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxInDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOrderid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonFix);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonSaveNew);
            this.Controls.Add(this.buttonModify);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrderSaleNew2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户订单（新增）";
            this.Load += new System.EventHandler(this.frmOrderSaleNew2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCheckDate;
        public System.Windows.Forms.Button buttonSaveNew;
        private System.Windows.Forms.Button buttonReturn;
        public System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFix;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxOrderid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOderperson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label label1;
        public ComboBoxMultiColumns.ComboBoxMultiColumns comboBoxMultiColumnsClientid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCheckPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ProductdataGridView1;
        private System.Windows.Forms.DateTimePicker OrderdateTimePicker1;
        private System.Windows.Forms.DateTimePicker DeliveryTimePicker2;
        private System.Windows.Forms.Button buttonModify;
    }
}