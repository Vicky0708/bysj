﻿namespace hx
{
    partial class frmFixProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFixProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.FixProductGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FixProductGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(598, 11);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(81, 44);
            this.buttonRefresh.TabIndex = 62;
            this.buttonRefresh.Text = "   刷新";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxName.Location = new System.Drawing.Point(312, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(149, 34);
            this.textBoxName.TabIndex = 60;
            // 
            // textBoxNo
            // 
            this.textBoxNo.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNo.Location = new System.Drawing.Point(84, 19);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(143, 34);
            this.textBoxNo.TabIndex = 59;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(233, 27);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(73, 19);
            this.radioButtonName.TabIndex = 58;
            this.radioButtonName.Text = "按品名";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Checked = true;
            this.radioButtonNo.Location = new System.Drawing.Point(5, 27);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(73, 19);
            this.radioButtonNo.TabIndex = 57;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "按编号";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(484, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(81, 44);
            this.buttonSearch.TabIndex = 56;
            this.buttonSearch.Text = "   查询";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Image = ((System.Drawing.Image)(resources.GetObject("buttonReturn.Image")));
            this.buttonReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReturn.Location = new System.Drawing.Point(860, 10);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(81, 44);
            this.buttonReturn.TabIndex = 55;
            this.buttonReturn.Text = "   返回";
            this.buttonReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonModify.FlatAppearance.BorderSize = 0;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Image = ((System.Drawing.Image)(resources.GetObject("buttonModify.Image")));
            this.buttonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModify.Location = new System.Drawing.Point(772, 10);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(81, 44);
            this.buttonModify.TabIndex = 54;
            this.buttonModify.Text = "   修改";
            this.buttonModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(588, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 62);
            this.label1.TabIndex = 53;
            this.label1.Text = "label1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(685, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 44);
            this.buttonAdd.TabIndex = 52;
            this.buttonAdd.Text = "   新增";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FixProductGridView1
            // 
            this.FixProductGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.FixProductGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.FixProductGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.FixProductGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FixProductGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FixProductGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FixProductGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.FixProductGridView1.Location = new System.Drawing.Point(5, 68);
            this.FixProductGridView1.Name = "FixProductGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FixProductGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FixProductGridView1.RowTemplate.Height = 27;
            this.FixProductGridView1.Size = new System.Drawing.Size(1092, 459);
            this.FixProductGridView1.TabIndex = 63;
            this.FixProductGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FixProductGridView1_CellContentClick);
            this.FixProductGridView1.DockChanged += new System.EventHandler(this.FixProductGridView1_DockChanged);
            this.FixProductGridView1.DoubleClick += new System.EventHandler(this.FixProductGridView1_DoubleClick);
            // 
            // frmFixProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 529);
            this.Controls.Add(this.FixProductGridView1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxNo);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFixProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "固定箱管理";
            this.Load += new System.EventHandler(this.frmFixProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FixProductGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNo;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReturn;
        public System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView FixProductGridView1;
    }
}