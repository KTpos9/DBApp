﻿namespace DBApps.QueryForm
{
    partial class FormRevQuery
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
            this.components = new System.ComponentModel.Container();
            this.movieDBDataSet = new DBApps.MovieDBDataSet();
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.revenueTableAdapter = new DBApps.MovieDBDataSetTableAdapters.RevenueTableAdapter();
            this.tableAdapterManager = new DBApps.MovieDBDataSetTableAdapters.TableAdapterManager();
            this.revenueDataGridView = new System.Windows.Forms.DataGridView();
            this.RevenueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevenueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevenueUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevenueType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevenuePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // movieDBDataSet
            // 
            this.movieDBDataSet.DataSetName = "MovieDBDataSet";
            this.movieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // revenueBindingSource
            // 
            this.revenueBindingSource.DataMember = "Revenue";
            this.revenueBindingSource.DataSource = this.movieDBDataSet;
            // 
            // revenueTableAdapter
            // 
            this.revenueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.MovieScheduleTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.RevenueTableAdapter = this.revenueTableAdapter;
            this.tableAdapterManager.UpdateOrder = DBApps.MovieDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // revenueDataGridView
            // 
            this.revenueDataGridView.AutoGenerateColumns = false;
            this.revenueDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.revenueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revenueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RevenueID,
            this.RevenueDate,
            this.RevenueUser,
            this.RevenueType,
            this.RevenuePrice,
            this.MovieID});
            this.revenueDataGridView.DataSource = this.revenueBindingSource;
            this.revenueDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.revenueDataGridView.Location = new System.Drawing.Point(0, 0);
            this.revenueDataGridView.Name = "revenueDataGridView";
            this.revenueDataGridView.RowHeadersWidth = 51;
            this.revenueDataGridView.RowTemplate.Height = 24;
            this.revenueDataGridView.Size = new System.Drawing.Size(823, 237);
            this.revenueDataGridView.TabIndex = 1;
            // 
            // RevenueID
            // 
            this.RevenueID.DataPropertyName = "RevenueID";
            this.RevenueID.HeaderText = "RevenueID";
            this.RevenueID.MinimumWidth = 6;
            this.RevenueID.Name = "RevenueID";
            this.RevenueID.Width = 125;
            // 
            // RevenueDate
            // 
            this.RevenueDate.DataPropertyName = "RevenueDate";
            this.RevenueDate.HeaderText = "RevenueDate";
            this.RevenueDate.MinimumWidth = 6;
            this.RevenueDate.Name = "RevenueDate";
            this.RevenueDate.Width = 125;
            // 
            // RevenueUser
            // 
            this.RevenueUser.DataPropertyName = "RevenueUser";
            this.RevenueUser.HeaderText = "RevenueUser";
            this.RevenueUser.MinimumWidth = 6;
            this.RevenueUser.Name = "RevenueUser";
            this.RevenueUser.Width = 125;
            // 
            // RevenueType
            // 
            this.RevenueType.DataPropertyName = "RevenueType";
            this.RevenueType.HeaderText = "RevenueType";
            this.RevenueType.MinimumWidth = 6;
            this.RevenueType.Name = "RevenueType";
            this.RevenueType.Width = 125;
            // 
            // RevenuePrice
            // 
            this.RevenuePrice.DataPropertyName = "RevenuePrice";
            this.RevenuePrice.HeaderText = "RevenuePrice";
            this.RevenuePrice.MinimumWidth = 6;
            this.RevenuePrice.Name = "RevenuePrice";
            this.RevenuePrice.Width = 125;
            // 
            // MovieID
            // 
            this.MovieID.DataPropertyName = "MovieID";
            this.MovieID.HeaderText = "MovieID";
            this.MovieID.MinimumWidth = 6;
            this.MovieID.Name = "MovieID";
            this.MovieID.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox14);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(281, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 180);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coulmns";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(196, 111);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(123, 25);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "RevenuePrice";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox5.Enter += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Checked = true;
            this.checkBox14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox14.Location = new System.Drawing.Point(19, 35);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(87, 25);
            this.checkBox14.TabIndex = 17;
            this.checkBox14.Text = "MovieID";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(197, 71);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(121, 25);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "RevenueDate";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(197, 33);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(104, 25);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "RevenueID";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(19, 111);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(121, 25);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "RevenueType";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(19, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 25);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "RevenueUser";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order By";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RevenueID",
            "RevenueDate\t",
            "RevenueUser",
            "RevenueType",
            "RevenuePrice",
            "MovieID"});
            this.comboBox1.Location = new System.Drawing.Point(17, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 29);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(32, 414);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(52, 21);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "label2";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(17, 328);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(105, 40);
            this.buttonExport.TabIndex = 11;
            this.buttonExport.Text = "Export Data";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // FormRevQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(823, 460);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.revenueDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRevQuery";
            this.Text = "FormRevQuery";
            this.Load += new System.EventHandler(this.FormRevQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private MovieDBDataSetTableAdapters.RevenueTableAdapter revenueTableAdapter;
        private MovieDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView revenueDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevenueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevenueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevenueUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevenueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevenuePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonExport;
    }
}