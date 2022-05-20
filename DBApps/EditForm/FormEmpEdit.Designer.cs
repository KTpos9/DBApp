namespace DBApps.EditForm
{
    partial class FormEmpEdit
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
            System.Windows.Forms.Label empIDLabel;
            System.Windows.Forms.Label empPasswordLabel;
            System.Windows.Forms.Label empSalaryLabel;
            System.Windows.Forms.Label empPositionIDLabel;
            System.Windows.Forms.Label empPositionLabel;
            System.Windows.Forms.Label empFnameLabel;
            System.Windows.Forms.Label empSnameLabel;
            System.Windows.Forms.Label empHouseNumLabel;
            System.Windows.Forms.Label empMooLabel;
            System.Windows.Forms.Label empSubDistrictLabel;
            System.Windows.Forms.Label empDistrictLabel;
            System.Windows.Forms.Label empProvinceLabel;
            System.Windows.Forms.Label empPostalCodeLabel;
            System.Windows.Forms.Label movieIDLabel;
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textEmpPositionID = new System.Windows.Forms.TextBox();
            this.comboEmpPosition = new System.Windows.Forms.ComboBox();
            this.textEmpName = new System.Windows.Forms.TextBox();
            this.textEmpSName = new System.Windows.Forms.TextBox();
            this.textEmpSalary = new System.Windows.Forms.TextBox();
            this.textEmpPass = new System.Windows.Forms.TextBox();
            this.textEmpID = new System.Windows.Forms.TextBox();
            this.textEmpPostalCode = new System.Windows.Forms.TextBox();
            this.textEmpHouseNum = new System.Windows.Forms.TextBox();
            this.textEmpMoo = new System.Windows.Forms.TextBox();
            this.textEmpSD = new System.Windows.Forms.TextBox();
            this.textEmpDistrict = new System.Windows.Forms.TextBox();
            this.textEmpProvince = new System.Windows.Forms.TextBox();
            this.textMovieID = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDBDataSet = new DBApps.MovieDBDataSet();
            this.employeeTableAdapter = new DBApps.MovieDBDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new DBApps.MovieDBDataSetTableAdapters.TableAdapterManager();
            empIDLabel = new System.Windows.Forms.Label();
            empPasswordLabel = new System.Windows.Forms.Label();
            empSalaryLabel = new System.Windows.Forms.Label();
            empPositionIDLabel = new System.Windows.Forms.Label();
            empPositionLabel = new System.Windows.Forms.Label();
            empFnameLabel = new System.Windows.Forms.Label();
            empSnameLabel = new System.Windows.Forms.Label();
            empHouseNumLabel = new System.Windows.Forms.Label();
            empMooLabel = new System.Windows.Forms.Label();
            empSubDistrictLabel = new System.Windows.Forms.Label();
            empDistrictLabel = new System.Windows.Forms.Label();
            empProvinceLabel = new System.Windows.Forms.Label();
            empPostalCodeLabel = new System.Windows.Forms.Label();
            movieIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(79, 269);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(63, 21);
            empIDLabel.TabIndex = 2;
            empIDLabel.Text = "Emp ID:";
            // 
            // empPasswordLabel
            // 
            empPasswordLabel.AutoSize = true;
            empPasswordLabel.Location = new System.Drawing.Point(29, 304);
            empPasswordLabel.Name = "empPasswordLabel";
            empPasswordLabel.Size = new System.Drawing.Size(113, 21);
            empPasswordLabel.TabIndex = 4;
            empPasswordLabel.Text = "Emp Password:";
            // 
            // empSalaryLabel
            // 
            empSalaryLabel.AutoSize = true;
            empSalaryLabel.Location = new System.Drawing.Point(51, 339);
            empSalaryLabel.Name = "empSalaryLabel";
            empSalaryLabel.Size = new System.Drawing.Size(91, 21);
            empSalaryLabel.TabIndex = 6;
            empSalaryLabel.Text = "Emp Salary:";
            // 
            // empPositionIDLabel
            // 
            empPositionIDLabel.AutoSize = true;
            empPositionIDLabel.Location = new System.Drawing.Point(19, 374);
            empPositionIDLabel.Name = "empPositionIDLabel";
            empPositionIDLabel.Size = new System.Drawing.Size(123, 21);
            empPositionIDLabel.TabIndex = 8;
            empPositionIDLabel.Text = "Emp Position ID:";
            // 
            // empPositionLabel
            // 
            empPositionLabel.AutoSize = true;
            empPositionLabel.Location = new System.Drawing.Point(38, 409);
            empPositionLabel.Name = "empPositionLabel";
            empPositionLabel.Size = new System.Drawing.Size(104, 21);
            empPositionLabel.TabIndex = 10;
            empPositionLabel.Text = "Emp Position:";
            // 
            // empFnameLabel
            // 
            empFnameLabel.AutoSize = true;
            empFnameLabel.Location = new System.Drawing.Point(47, 444);
            empFnameLabel.Name = "empFnameLabel";
            empFnameLabel.Size = new System.Drawing.Size(95, 21);
            empFnameLabel.TabIndex = 12;
            empFnameLabel.Text = "Emp Fname:";
            // 
            // empSnameLabel
            // 
            empSnameLabel.AutoSize = true;
            empSnameLabel.Location = new System.Drawing.Point(46, 479);
            empSnameLabel.Name = "empSnameLabel";
            empSnameLabel.Size = new System.Drawing.Size(96, 21);
            empSnameLabel.TabIndex = 14;
            empSnameLabel.Text = "Emp Sname:";
            // 
            // empHouseNumLabel
            // 
            empHouseNumLabel.AutoSize = true;
            empHouseNumLabel.Location = new System.Drawing.Point(362, 269);
            empHouseNumLabel.Name = "empHouseNumLabel";
            empHouseNumLabel.Size = new System.Drawing.Size(131, 21);
            empHouseNumLabel.TabIndex = 16;
            empHouseNumLabel.Text = "Emp House Num:";
            // 
            // empMooLabel
            // 
            empMooLabel.AutoSize = true;
            empMooLabel.Location = new System.Drawing.Point(413, 304);
            empMooLabel.Name = "empMooLabel";
            empMooLabel.Size = new System.Drawing.Size(80, 21);
            empMooLabel.TabIndex = 18;
            empMooLabel.Text = "Emp Moo:";
            // 
            // empSubDistrictLabel
            // 
            empSubDistrictLabel.AutoSize = true;
            empSubDistrictLabel.Location = new System.Drawing.Point(362, 339);
            empSubDistrictLabel.Name = "empSubDistrictLabel";
            empSubDistrictLabel.Size = new System.Drawing.Size(131, 21);
            empSubDistrictLabel.TabIndex = 20;
            empSubDistrictLabel.Text = "Emp Sub District:";
            // 
            // empDistrictLabel
            // 
            empDistrictLabel.AutoSize = true;
            empDistrictLabel.Location = new System.Drawing.Point(393, 374);
            empDistrictLabel.Name = "empDistrictLabel";
            empDistrictLabel.Size = new System.Drawing.Size(100, 21);
            empDistrictLabel.TabIndex = 22;
            empDistrictLabel.Text = "Emp District:";
            // 
            // empProvinceLabel
            // 
            empProvinceLabel.AutoSize = true;
            empProvinceLabel.Location = new System.Drawing.Point(384, 409);
            empProvinceLabel.Name = "empProvinceLabel";
            empProvinceLabel.Size = new System.Drawing.Size(109, 21);
            empProvinceLabel.TabIndex = 24;
            empProvinceLabel.Text = "Emp Province:";
            // 
            // empPostalCodeLabel
            // 
            empPostalCodeLabel.AutoSize = true;
            empPostalCodeLabel.Location = new System.Drawing.Point(362, 444);
            empPostalCodeLabel.Name = "empPostalCodeLabel";
            empPostalCodeLabel.Size = new System.Drawing.Size(131, 21);
            empPostalCodeLabel.TabIndex = 26;
            empPostalCodeLabel.Text = "Emp Postal Code:";
            // 
            // movieIDLabel
            // 
            movieIDLabel.AutoSize = true;
            movieIDLabel.Location = new System.Drawing.Point(413, 479);
            movieIDLabel.Name = "movieIDLabel";
            movieIDLabel.Size = new System.Drawing.Size(75, 21);
            movieIDLabel.TabIndex = 28;
            movieIDLabel.Text = "Movie ID:";
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(892, 235);
            this.employeeDataGridView.TabIndex = 1;
            this.employeeDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employeeDataGridView_RowHeaderMouseClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(733, 454);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 38);
            this.buttonClear.TabIndex = 30;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textEmpPositionID
            // 
            this.textEmpPositionID.Location = new System.Drawing.Point(148, 371);
            this.textEmpPositionID.Name = "textEmpPositionID";
            this.textEmpPositionID.Size = new System.Drawing.Size(171, 29);
            this.textEmpPositionID.TabIndex = 31;
            // 
            // comboEmpPosition
            // 
            this.comboEmpPosition.FormattingEnabled = true;
            this.comboEmpPosition.Location = new System.Drawing.Point(148, 406);
            this.comboEmpPosition.Name = "comboEmpPosition";
            this.comboEmpPosition.Size = new System.Drawing.Size(171, 29);
            this.comboEmpPosition.TabIndex = 32;
            // 
            // textEmpName
            // 
            this.textEmpName.Location = new System.Drawing.Point(148, 441);
            this.textEmpName.Name = "textEmpName";
            this.textEmpName.Size = new System.Drawing.Size(171, 29);
            this.textEmpName.TabIndex = 33;
            // 
            // textEmpSName
            // 
            this.textEmpSName.Location = new System.Drawing.Point(148, 476);
            this.textEmpSName.Name = "textEmpSName";
            this.textEmpSName.Size = new System.Drawing.Size(171, 29);
            this.textEmpSName.TabIndex = 33;
            // 
            // textEmpSalary
            // 
            this.textEmpSalary.Location = new System.Drawing.Point(148, 336);
            this.textEmpSalary.Name = "textEmpSalary";
            this.textEmpSalary.Size = new System.Drawing.Size(171, 29);
            this.textEmpSalary.TabIndex = 33;
            // 
            // textEmpPass
            // 
            this.textEmpPass.Location = new System.Drawing.Point(148, 301);
            this.textEmpPass.Name = "textEmpPass";
            this.textEmpPass.Size = new System.Drawing.Size(171, 29);
            this.textEmpPass.TabIndex = 33;
            // 
            // textEmpID
            // 
            this.textEmpID.Location = new System.Drawing.Point(148, 266);
            this.textEmpID.Name = "textEmpID";
            this.textEmpID.Size = new System.Drawing.Size(171, 29);
            this.textEmpID.TabIndex = 33;
            // 
            // textEmpPostalCode
            // 
            this.textEmpPostalCode.Location = new System.Drawing.Point(499, 441);
            this.textEmpPostalCode.Name = "textEmpPostalCode";
            this.textEmpPostalCode.Size = new System.Drawing.Size(171, 29);
            this.textEmpPostalCode.TabIndex = 33;
            // 
            // textEmpHouseNum
            // 
            this.textEmpHouseNum.Location = new System.Drawing.Point(499, 266);
            this.textEmpHouseNum.Name = "textEmpHouseNum";
            this.textEmpHouseNum.Size = new System.Drawing.Size(171, 29);
            this.textEmpHouseNum.TabIndex = 33;
            // 
            // textEmpMoo
            // 
            this.textEmpMoo.Location = new System.Drawing.Point(499, 301);
            this.textEmpMoo.Name = "textEmpMoo";
            this.textEmpMoo.Size = new System.Drawing.Size(171, 29);
            this.textEmpMoo.TabIndex = 33;
            // 
            // textEmpSD
            // 
            this.textEmpSD.Location = new System.Drawing.Point(499, 336);
            this.textEmpSD.Name = "textEmpSD";
            this.textEmpSD.Size = new System.Drawing.Size(171, 29);
            this.textEmpSD.TabIndex = 33;
            // 
            // textEmpDistrict
            // 
            this.textEmpDistrict.Location = new System.Drawing.Point(499, 371);
            this.textEmpDistrict.Name = "textEmpDistrict";
            this.textEmpDistrict.Size = new System.Drawing.Size(171, 29);
            this.textEmpDistrict.TabIndex = 33;
            // 
            // textEmpProvince
            // 
            this.textEmpProvince.Location = new System.Drawing.Point(499, 406);
            this.textEmpProvince.Name = "textEmpProvince";
            this.textEmpProvince.Size = new System.Drawing.Size(171, 29);
            this.textEmpProvince.TabIndex = 33;
            // 
            // textMovieID
            // 
            this.textMovieID.Location = new System.Drawing.Point(499, 476);
            this.textMovieID.Name = "textMovieID";
            this.textMovieID.Size = new System.Drawing.Size(171, 29);
            this.textMovieID.TabIndex = 33;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(733, 322);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(87, 38);
            this.buttonInsert.TabIndex = 30;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(733, 366);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(87, 38);
            this.buttonUpdate.TabIndex = 30;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(733, 410);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(87, 38);
            this.buttonDelete.TabIndex = 30;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmpID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmpID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmpPassword";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmpPassword";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmpSalary";
            this.dataGridViewTextBoxColumn3.HeaderText = "EmpSalary";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EmpPositionID";
            this.dataGridViewTextBoxColumn4.HeaderText = "EmpPositionID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EmpPosition";
            this.dataGridViewTextBoxColumn5.HeaderText = "EmpPosition";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EmpFname";
            this.dataGridViewTextBoxColumn6.HeaderText = "EmpFname";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EmpSname";
            this.dataGridViewTextBoxColumn7.HeaderText = "EmpSname";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EmpHouseNum";
            this.dataGridViewTextBoxColumn8.HeaderText = "EmpHouseNum";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EmpMoo";
            this.dataGridViewTextBoxColumn9.HeaderText = "EmpMoo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "EmpSubDistrict";
            this.dataGridViewTextBoxColumn10.HeaderText = "EmpSubDistrict";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "EmpDistrict";
            this.dataGridViewTextBoxColumn11.HeaderText = "EmpDistrict";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EmpProvince";
            this.dataGridViewTextBoxColumn12.HeaderText = "EmpProvince";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "EmpPostalCode";
            this.dataGridViewTextBoxColumn13.HeaderText = "EmpPostalCode";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "MovieID";
            this.dataGridViewTextBoxColumn14.HeaderText = "MovieID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
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
            // FormEmpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 528);
            this.Controls.Add(this.textEmpProvince);
            this.Controls.Add(this.textEmpDistrict);
            this.Controls.Add(this.textEmpSD);
            this.Controls.Add(this.textEmpMoo);
            this.Controls.Add(this.textEmpHouseNum);
            this.Controls.Add(this.textMovieID);
            this.Controls.Add(this.textEmpPostalCode);
            this.Controls.Add(this.textEmpSName);
            this.Controls.Add(this.textEmpID);
            this.Controls.Add(this.textEmpPass);
            this.Controls.Add(this.textEmpSalary);
            this.Controls.Add(this.textEmpName);
            this.Controls.Add(this.comboEmpPosition);
            this.Controls.Add(this.textEmpPositionID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(empIDLabel);
            this.Controls.Add(empPasswordLabel);
            this.Controls.Add(empSalaryLabel);
            this.Controls.Add(empPositionIDLabel);
            this.Controls.Add(empPositionLabel);
            this.Controls.Add(empFnameLabel);
            this.Controls.Add(empSnameLabel);
            this.Controls.Add(empHouseNumLabel);
            this.Controls.Add(empMooLabel);
            this.Controls.Add(empSubDistrictLabel);
            this.Controls.Add(empDistrictLabel);
            this.Controls.Add(empProvinceLabel);
            this.Controls.Add(empPostalCodeLabel);
            this.Controls.Add(movieIDLabel);
            this.Controls.Add(this.employeeDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEmpEdit";
            this.Text = "FormEmpEdit";
            this.Load += new System.EventHandler(this.FormEmpEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MovieDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private MovieDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textEmpPositionID;
        private System.Windows.Forms.ComboBox comboEmpPosition;
        private System.Windows.Forms.TextBox textEmpName;
        private System.Windows.Forms.TextBox textEmpSName;
        private System.Windows.Forms.TextBox textEmpSalary;
        private System.Windows.Forms.TextBox textEmpPass;
        private System.Windows.Forms.TextBox textEmpID;
        private System.Windows.Forms.TextBox textEmpPostalCode;
        private System.Windows.Forms.TextBox textEmpHouseNum;
        private System.Windows.Forms.TextBox textEmpMoo;
        private System.Windows.Forms.TextBox textEmpSD;
        private System.Windows.Forms.TextBox textEmpDistrict;
        private System.Windows.Forms.TextBox textEmpProvince;
        private System.Windows.Forms.TextBox textMovieID;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}