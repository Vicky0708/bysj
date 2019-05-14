namespace hx
{
    partial class frmPurchaseAdd4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseAdd4));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPurchasePerson = new System.Windows.Forms.TextBox();
            this.textBoxPurchaseid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PurchasedateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.PurchaseOrderdataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ClientdataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.SupidcomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DeliveryTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSaveNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseOrderdataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReturn.Image = ((System.Drawing.Image)(resources.GetObject("buttonReturn.Image")));
            this.buttonReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReturn.Location = new System.Drawing.Point(366, 12);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(92, 42);
            this.buttonReturn.TabIndex = 77;
            this.buttonReturn.Text = "     返回";
            this.buttonReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 84;
            this.label4.Text = "开单员";
            // 
            // textBoxPurchasePerson
            // 
            this.textBoxPurchasePerson.Enabled = false;
            this.textBoxPurchasePerson.Location = new System.Drawing.Point(325, 71);
            this.textBoxPurchasePerson.Name = "textBoxPurchasePerson";
            this.textBoxPurchasePerson.Size = new System.Drawing.Size(118, 25);
            this.textBoxPurchasePerson.TabIndex = 83;
            // 
            // textBoxPurchaseid
            // 
            this.textBoxPurchaseid.Enabled = false;
            this.textBoxPurchaseid.Location = new System.Drawing.Point(97, 71);
            this.textBoxPurchaseid.Name = "textBoxPurchaseid";
            this.textBoxPurchaseid.Size = new System.Drawing.Size(145, 25);
            this.textBoxPurchaseid.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "采购单号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 85;
            this.label1.Text = "供方编码";
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Enabled = false;
            this.textBoxSupplierName.Location = new System.Drawing.Point(667, 71);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(146, 25);
            this.textBoxSupplierName.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 104;
            this.label3.Text = "日期";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PurchasedateTimePicker2
            // 
            this.PurchasedateTimePicker2.Location = new System.Drawing.Point(97, 115);
            this.PurchasedateTimePicker2.Name = "PurchasedateTimePicker2";
            this.PurchasedateTimePicker2.Size = new System.Drawing.Size(145, 25);
            this.PurchasedateTimePicker2.TabIndex = 113;
            this.PurchasedateTimePicker2.ValueChanged += new System.EventHandler(this.PurchasedateTimePicker2_ValueChanged);
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Location = new System.Drawing.Point(97, 159);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new System.Drawing.Size(716, 25);
            this.textBoxMemo.TabIndex = 115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 114;
            this.label5.Text = "备注";
            // 
            // buttonChoose
            // 
            this.buttonChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChoose.Image = ((System.Drawing.Image)(resources.GetObject("buttonChoose.Image")));
            this.buttonChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChoose.Location = new System.Drawing.Point(12, 12);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(107, 42);
            this.buttonChoose.TabIndex = 138;
            this.buttonChoose.Text = "简易采购";
            this.buttonChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click_1);
            // 
            // PurchaseOrderdataGridView2
            // 
            this.PurchaseOrderdataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PurchaseOrderdataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PurchaseOrderdataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PurchaseOrderdataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchaseOrderdataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.PurchaseOrderdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchaseOrderdataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.PurchaseOrderdataGridView2.Location = new System.Drawing.Point(8, 237);
            this.PurchaseOrderdataGridView2.Name = "PurchaseOrderdataGridView2";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchaseOrderdataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.PurchaseOrderdataGridView2.RowTemplate.Height = 27;
            this.PurchaseOrderdataGridView2.Size = new System.Drawing.Size(713, 293);
            this.PurchaseOrderdataGridView2.TabIndex = 143;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 19);
            this.label6.TabIndex = 144;
            this.label6.Text = "以下为本采购单的纸板明细";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(246, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 42);
            this.button2.TabIndex = 164;
            this.button2.Text = "预览打印";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ClientdataGridView1
            // 
            this.ClientdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ClientdataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ClientdataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ClientdataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientdataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ClientdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientdataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.ClientdataGridView1.Enabled = false;
            this.ClientdataGridView1.Location = new System.Drawing.Point(622, 237);
            this.ClientdataGridView1.Name = "ClientdataGridView1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientdataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.ClientdataGridView1.RowTemplate.Height = 27;
            this.ClientdataGridView1.Size = new System.Drawing.Size(658, 293);
            this.ClientdataGridView1.TabIndex = 146;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(663, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 19);
            this.label8.TabIndex = 165;
            this.label8.Text = "以下为左边订购的纸板所属订单明细";
            // 
            // SupidcomboBox
            // 
            this.SupidcomboBox.FormattingEnabled = true;
            this.SupidcomboBox.Location = new System.Drawing.Point(540, 71);
            this.SupidcomboBox.Name = "SupidcomboBox";
            this.SupidcomboBox.Size = new System.Drawing.Size(121, 23);
            this.SupidcomboBox.TabIndex = 166;
            this.SupidcomboBox.SelectedIndexChanged += new System.EventHandler(this.SupidcomboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(594, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 168;
            this.label10.Text = "交货日期";
            // 
            // DeliveryTimePicker2
            // 
            this.DeliveryTimePicker2.Location = new System.Drawing.Point(667, 115);
            this.DeliveryTimePicker2.Name = "DeliveryTimePicker2";
            this.DeliveryTimePicker2.Size = new System.Drawing.Size(146, 25);
            this.DeliveryTimePicker2.TabIndex = 167;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(266, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 19);
            this.label7.TabIndex = 145;
            this.label7.Text = "当采购单号生成后，日期将无法修改。";
            // 
            // buttonSaveNew
            // 
            this.buttonSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSaveNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveNew.Image")));
            this.buttonSaveNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveNew.Location = new System.Drawing.Point(125, 12);
            this.buttonSaveNew.Name = "buttonSaveNew";
            this.buttonSaveNew.Size = new System.Drawing.Size(115, 42);
            this.buttonSaveNew.TabIndex = 169;
            this.buttonSaveNew.Text = "全部保存";
            this.buttonSaveNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveNew.UseVisualStyleBackColor = true;
            this.buttonSaveNew.Click += new System.EventHandler(this.buttonSaveNew_Click);
            // 
            // frmPurchaseAdd4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 542);
            this.Controls.Add(this.buttonSaveNew);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeliveryTimePicker2);
            this.Controls.Add(this.SupidcomboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClientdataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PurchaseOrderdataGridView2);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.textBoxMemo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PurchasedateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSupplierName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPurchasePerson);
            this.Controls.Add(this.textBoxPurchaseid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPurchaseAdd4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购单";
            this.Load += new System.EventHandler(this.frmPurchaseAdd4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseOrderdataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPurchasePerson;
        public System.Windows.Forms.TextBox textBoxPurchaseid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSupplierName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker PurchasedateTimePicker2;
        private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.DataGridView PurchaseOrderdataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView ClientdataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SupidcomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DeliveryTimePicker2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button buttonSaveNew;
    }
}