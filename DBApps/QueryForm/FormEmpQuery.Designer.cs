namespace DBApps.Forms
{
    partial class FormEmpQuery
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
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDBDataSet = new DBApps.MovieDBDataSet();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPositionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpSname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpHouseNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpMoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpSubDistrict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpDistrict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.employeeTableAdapter = new DBApps.MovieDBDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new DBApps.MovieDBDataSetTableAdapters.TableAdapterManager();
            this.buttonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.movieDBDataSet;
            // 
            // movieDBDataSet
            // 
            this.movieDBDataSet.DataSetName = "MovieDBDataSet";
            this.movieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpPassword,
            this.EmpSalary,
            this.EmpPositionID,
            this.EmpPosition,
            this.EmpFname,
            this.EmpSname,
            this.EmpHouseNum,
            this.EmpMoo,
            this.EmpSubDistrict,
            this.EmpDistrict,
            this.EmpProvince,
            this.EmpPostalCode,
            this.MovieID});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.Size = new System.Drawing.Size(823, 220);
            this.employeeDataGridView.TabIndex = 1;
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "EmpID";
            this.EmpID.HeaderText = "EmpID";
            this.EmpID.MinimumWidth = 6;
            this.EmpID.Name = "EmpID";
            this.EmpID.Width = 125;
            // 
            // EmpPassword
            // 
            this.EmpPassword.DataPropertyName = "EmpPassword";
            this.EmpPassword.HeaderText = "EmpPassword";
            this.EmpPassword.MinimumWidth = 6;
            this.EmpPassword.Name = "EmpPassword";
            this.EmpPassword.Width = 125;
            // 
            // EmpSalary
            // 
            this.EmpSalary.DataPropertyName = "EmpSalary";
            this.EmpSalary.HeaderText = "EmpSalary";
            this.EmpSalary.MinimumWidth = 6;
            this.EmpSalary.Name = "EmpSalary";
            this.EmpSalary.Width = 125;
            // 
            // EmpPositionID
            // 
            this.EmpPositionID.DataPropertyName = "EmpPositionID";
            this.EmpPositionID.HeaderText = "EmpPositionID";
            this.EmpPositionID.MinimumWidth = 6;
            this.EmpPositionID.Name = "EmpPositionID";
            this.EmpPositionID.Width = 125;
            // 
            // EmpPosition
            // 
            this.EmpPosition.DataPropertyName = "EmpPosition";
            this.EmpPosition.HeaderText = "EmpPosition";
            this.EmpPosition.MinimumWidth = 6;
            this.EmpPosition.Name = "EmpPosition";
            this.EmpPosition.Width = 125;
            // 
            // EmpFname
            // 
            this.EmpFname.DataPropertyName = "EmpFname";
            this.EmpFname.HeaderText = "EmpFname";
            this.EmpFname.MinimumWidth = 6;
            this.EmpFname.Name = "EmpFname";
            this.EmpFname.Width = 125;
            // 
            // EmpSname
            // 
            this.EmpSname.DataPropertyName = "EmpSname";
            this.EmpSname.HeaderText = "EmpSname";
            this.EmpSname.MinimumWidth = 6;
            this.EmpSname.Name = "EmpSname";
            this.EmpSname.Width = 125;
            // 
            // EmpHouseNum
            // 
            this.EmpHouseNum.DataPropertyName = "EmpHouseNum";
            this.EmpHouseNum.HeaderText = "EmpHouseNum";
            this.EmpHouseNum.MinimumWidth = 6;
            this.EmpHouseNum.Name = "EmpHouseNum";
            this.EmpHouseNum.Width = 125;
            // 
            // EmpMoo
            // 
            this.EmpMoo.DataPropertyName = "EmpMoo";
            this.EmpMoo.HeaderText = "EmpMoo";
            this.EmpMoo.MinimumWidth = 6;
            this.EmpMoo.Name = "EmpMoo";
            this.EmpMoo.Width = 125;
            // 
            // EmpSubDistrict
            // 
            this.EmpSubDistrict.DataPropertyName = "EmpSubDistrict";
            this.EmpSubDistrict.HeaderText = "EmpSubDistrict";
            this.EmpSubDistrict.MinimumWidth = 6;
            this.EmpSubDistrict.Name = "EmpSubDistrict";
            this.EmpSubDistrict.Width = 125;
            // 
            // EmpDistrict
            // 
            this.EmpDistrict.DataPropertyName = "EmpDistrict";
            this.EmpDistrict.HeaderText = "EmpDistrict";
            this.EmpDistrict.MinimumWidth = 6;
            this.EmpDistrict.Name = "EmpDistrict";
            this.EmpDistrict.Width = 125;
            // 
            // EmpProvince
            // 
            this.EmpProvince.DataPropertyName = "EmpProvince";
            this.EmpProvince.HeaderText = "EmpProvince";
            this.EmpProvince.MinimumWidth = 6;
            this.EmpProvince.Name = "EmpProvince";
            this.EmpProvince.Width = 125;
            // 
            // EmpPostalCode
            // 
            this.EmpPostalCode.DataPropertyName = "EmpPostalCode";
            this.EmpPostalCode.HeaderText = "EmpPostalCode";
            this.EmpPostalCode.MinimumWidth = 6;
            this.EmpPostalCode.Name = "EmpPostalCode";
            this.EmpPostalCode.Width = 125;
            // 
            // MovieID
            // 
            this.MovieID.DataPropertyName = "MovieID";
            this.MovieID.HeaderText = "MovieID";
            this.MovieID.MinimumWidth = 6;
            this.MovieID.Name = "MovieID";
            this.MovieID.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EmpID",
            "EmpPassword",
            "EmpSalary",
            "EmpPositionID",
            "EmpFname",
            "EmpSname",
            "EmpHouseNum",
            "EmpMoo",
            "EmpSubDistrict",
            "EmpDistrict",
            "EmpPrivince",
            "EmpPostalCode",
            "MovieID"});
            this.comboBox1.Location = new System.Drawing.Point(12, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order By";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 25);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "EmpID";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox14);
            this.groupBox1.Controls.Add(this.checkBox13);
            this.groupBox1.Controls.Add(this.checkBox12);
            this.groupBox1.Controls.Add(this.checkBox11);
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(251, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 180);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coulmns";
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Checked = true;
            this.checkBox14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox14.Location = new System.Drawing.Point(183, 142);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(87, 25);
            this.checkBox14.TabIndex = 17;
            this.checkBox14.Text = "MovieID";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Checked = true;
            this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox13.Location = new System.Drawing.Point(6, 142);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(137, 25);
            this.checkBox13.TabIndex = 16;
            this.checkBox13.Text = "EmpPostalCode";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Checked = true;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.Location = new System.Drawing.Point(437, 105);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(120, 25);
            this.checkBox12.TabIndex = 15;
            this.checkBox12.Text = "EmpProvince";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Location = new System.Drawing.Point(296, 105);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(109, 25);
            this.checkBox11.TabIndex = 14;
            this.checkBox11.Text = "EmpDistrict";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Location = new System.Drawing.Point(121, 105);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(136, 25);
            this.checkBox10.TabIndex = 13;
            this.checkBox10.Text = "EmpSubDistrict";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Location = new System.Drawing.Point(6, 105);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(92, 25);
            this.checkBox9.TabIndex = 12;
            this.checkBox9.Text = "EmpMoo";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(419, 67);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(139, 25);
            this.checkBox8.TabIndex = 11;
            this.checkBox8.Text = "EmpHouseNum";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(281, 67);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(108, 25);
            this.checkBox7.TabIndex = 10;
            this.checkBox7.Text = "EmpSname";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(144, 67);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(107, 25);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Text = "EmpFname";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(6, 67);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(115, 25);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "EmpPosition";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(396, 28);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(130, 25);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "EmpPositionID";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(264, 28);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(103, 25);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "EmpSalary";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(104, 28);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 25);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "EmpPassword";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.MovieScheduleTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.RevenueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DBApps.MovieDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(12, 310);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(105, 40);
            this.buttonExport.TabIndex = 6;
            this.buttonExport.Text = "Export Data";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // FormEmpQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(823, 460);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.employeeDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEmpQuery";
            this.Text = "FormEmpQuery";
            this.Load += new System.EventHandler(this.FormEmpQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MovieDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private MovieDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPositionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpSname;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpHouseNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpMoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpSubDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Button buttonExport;
    }
}