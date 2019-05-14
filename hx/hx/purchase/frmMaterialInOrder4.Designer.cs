namespace hx
{
    partial class frmMaterialInOrder4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterialInOrder4));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxProductInId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.MaterialIndataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxperson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDingdanDate = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonSaveNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckdateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSup = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ClientdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialIndataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 156;
            this.label8.Text = "开单日期";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxProductInId
            // 
            this.textBoxProductInId.Enabled = false;
            this.textBoxProductInId.Location = new System.Drawing.Point(85, 76);
            this.textBoxProductInId.Name = "textBoxProductInId";
            this.textBoxProductInId.Size = new System.Drawing.Size(158, 25);
            this.textBoxProductInId.TabIndex = 155;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 154;
            this.label3.Text = "入仓单号";
            // 
            // buttonChoose
            // 
            this.buttonChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChoose.Image = ((System.Drawing.Image)(resources.GetObject("buttonChoose.Image")));
            this.buttonChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChoose.Location = new System.Drawing.Point(372, 12);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(92, 42);
            this.buttonChoose.TabIndex = 153;
            this.buttonChoose.Text = "选择";
            this.buttonChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // MaterialIndataGridView1
            // 
            this.MaterialIndataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MaterialIndataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MaterialIndataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MaterialIndataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialIndataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MaterialIndataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialIndataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaterialIndataGridView1.Location = new System.Drawing.Point(0, 237);
            this.MaterialIndataGridView1.Name = "MaterialIndataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialIndataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MaterialIndataGridView1.RowTemplate.Height = 27;
            this.MaterialIndataGridView1.Size = new System.Drawing.Size(766, 293);
            this.MaterialIndataGridView1.TabIndex = 152;
            this.MaterialIndataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaterialIndataGridView1_CellEndEdit);
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Location = new System.Drawing.Point(85, 186);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new System.Drawing.Size(645, 25);
            this.textBoxMemo.TabIndex = 151;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 150;
            this.label5.Text = "备注";
            // 
            // textBoxperson
            // 
            this.textBoxperson.Enabled = false;
            this.textBoxperson.Location = new System.Drawing.Point(604, 76);
            this.textBoxperson.Name = "textBoxperson";
            this.textBoxperson.Size = new System.Drawing.Size(126, 25);
            this.textBoxperson.TabIndex = 148;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 147;
            this.label4.Text = "开单员";
            // 
            // textBoxDingdanDate
            // 
            this.textBoxDingdanDate.Enabled = false;
            this.textBoxDingdanDate.Location = new System.Drawing.Point(366, 76);
            this.textBoxDingdanDate.Name = "textBoxDingdanDate";
            this.textBoxDingdanDate.Size = new System.Drawing.Size(163, 25);
            this.textBoxDingdanDate.TabIndex = 146;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(85, 17);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(158, 25);
            this.textBoxId.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 144;
            this.label2.Text = "采购序号";
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(470, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 42);
            this.buttonDelete.TabIndex = 143;
            this.buttonDelete.Text = "整单删除";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReturn.Image = ((System.Drawing.Image)(resources.GetObject("buttonReturn.Image")));
            this.buttonReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReturn.Location = new System.Drawing.Point(705, 13);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(92, 42);
            this.buttonReturn.TabIndex = 142;
            this.buttonReturn.Text = "     返回";
            this.buttonReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSaveNew
            // 
            this.buttonSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSaveNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveNew.Image")));
            this.buttonSaveNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveNew.Location = new System.Drawing.Point(274, 12);
            this.buttonSaveNew.Name = "buttonSaveNew";
            this.buttonSaveNew.Size = new System.Drawing.Size(92, 42);
            this.buttonSaveNew.TabIndex = 141;
            this.buttonSaveNew.Text = "新增";
            this.buttonSaveNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveNew.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 157;
            this.label6.Text = "入仓日期";
            // 
            // CheckdateTimePicker2
            // 
            this.CheckdateTimePicker2.Location = new System.Drawing.Point(85, 133);
            this.CheckdateTimePicker2.Name = "CheckdateTimePicker2";
            this.CheckdateTimePicker2.Size = new System.Drawing.Size(158, 25);
            this.CheckdateTimePicker2.TabIndex = 158;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 159;
            this.label1.Text = "供方";
            // 
            // textBoxSup
            // 
            this.textBoxSup.Enabled = false;
            this.textBoxSup.Location = new System.Drawing.Point(366, 133);
            this.textBoxSup.Name = "textBoxSup";
            this.textBoxSup.Size = new System.Drawing.Size(364, 25);
            this.textBoxSup.TabIndex = 160;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(585, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 42);
            this.button2.TabIndex = 161;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientdataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClientdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientdataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClientdataGridView1.Enabled = false;
            this.ClientdataGridView1.Location = new System.Drawing.Point(681, 237);
            this.ClientdataGridView1.Name = "ClientdataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientdataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ClientdataGridView1.RowTemplate.Height = 27;
            this.ClientdataGridView1.Size = new System.Drawing.Size(658, 293);
            this.ClientdataGridView1.TabIndex = 162;
            this.ClientdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientdataGridView1_CellContentClick);
            this.ClientdataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientdataGridView1_CellValueChanged);
            // 
            // frmMaterialInOrder4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 542);
            this.Controls.Add(this.ClientdataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckdateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxProductInId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.MaterialIndataGridView1);
            this.Controls.Add(this.textBoxMemo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxperson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDingdanDate);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonSaveNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaterialInOrder4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "纸板入仓单";
            this.Load += new System.EventHandler(this.frmMaterialInOrder4_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialIndataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxProductInId;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.DataGridView MaterialIndataGridView1;
        private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxperson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDingdanDate;
        public System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReturn;
        public System.Windows.Forms.Button buttonSaveNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker CheckdateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView ClientdataGridView1;
    }
}