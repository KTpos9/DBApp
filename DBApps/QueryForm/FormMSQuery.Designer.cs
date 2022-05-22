namespace DBApps.QueryForm
{
    partial class FormMSQuery
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
            this.movieScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieScheduleTableAdapter = new DBApps.MovieDBDataSetTableAdapters.MovieScheduleTableAdapter();
            this.tableAdapterManager = new DBApps.MovieDBDataSetTableAdapters.TableAdapterManager();
            this.movieScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.MSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieScheduleDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // movieDBDataSet
            // 
            this.movieDBDataSet.DataSetName = "MovieDBDataSet";
            this.movieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieScheduleBindingSource
            // 
            this.movieScheduleBindingSource.DataMember = "MovieSchedule";
            this.movieScheduleBindingSource.DataSource = this.movieDBDataSet;
            // 
            // movieScheduleTableAdapter
            // 
            this.movieScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.MovieScheduleTableAdapter = this.movieScheduleTableAdapter;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.RevenueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DBApps.MovieDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // movieScheduleDataGridView
            // 
            this.movieScheduleDataGridView.AutoGenerateColumns = false;
            this.movieScheduleDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.movieScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieScheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSID,
            this.MSTime,
            this.MSDate,
            this.MSAdd,
            this.MovieID});
            this.movieScheduleDataGridView.DataSource = this.movieScheduleBindingSource;
            this.movieScheduleDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.movieScheduleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.movieScheduleDataGridView.Name = "movieScheduleDataGridView";
            this.movieScheduleDataGridView.Size = new System.Drawing.Size(683, 220);
            this.movieScheduleDataGridView.TabIndex = 1;
            // 
            // MSID
            // 
            this.MSID.DataPropertyName = "MSID";
            this.MSID.HeaderText = "MSID";
            this.MSID.Name = "MSID";
            // 
            // MSTime
            // 
            this.MSTime.DataPropertyName = "MSTime";
            this.MSTime.HeaderText = "MSTime";
            this.MSTime.Name = "MSTime";
            // 
            // MSDate
            // 
            this.MSDate.DataPropertyName = "MSDate";
            this.MSDate.HeaderText = "MSDate";
            this.MSDate.Name = "MSDate";
            // 
            // MSAdd
            // 
            this.MSAdd.DataPropertyName = "MSAdd";
            this.MSAdd.HeaderText = "MSAdd";
            this.MSAdd.Name = "MSAdd";
            // 
            // MovieID
            // 
            this.MovieID.DataPropertyName = "MovieID";
            this.MovieID.HeaderText = "MovieID";
            this.MovieID.Name = "MovieID";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(7, 293);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(105, 40);
            this.buttonExport.TabIndex = 10;
            this.buttonExport.Text = "Export Data";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox13);
            this.groupBox1.Controls.Add(this.checkBox12);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(246, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 180);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coulmns";
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Checked = true;
            this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox13.Location = new System.Drawing.Point(131, 65);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(87, 25);
            this.checkBox13.TabIndex = 16;
            this.checkBox13.Text = "MovieID";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Checked = true;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.Location = new System.Drawing.Point(437, 105);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(121, 25);
            this.checkBox12.TabIndex = 15;
            this.checkBox12.Text = "EmpProvince";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(277, 28);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 25);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "MSDate";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Location = new System.Drawing.Point(131, 28);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(86, 25);
            this.checkBox9.TabIndex = 12;
            this.checkBox9.Text = "MSTime";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(6, 67);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 25);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "MSAdd";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 25);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "MSID";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order By";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MSID",
            "MSTime",
            "MSDate",
            "MSAdd",
            "MovieID"});
            this.comboBox1.Location = new System.Drawing.Point(7, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 29);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormMSQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 406);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.movieScheduleDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMSQuery";
            this.Text = "FormMSQuery";
            this.Load += new System.EventHandler(this.FormMSQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieScheduleDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource movieScheduleBindingSource;
        private MovieDBDataSetTableAdapters.MovieScheduleTableAdapter movieScheduleTableAdapter;
        private MovieDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView movieScheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}