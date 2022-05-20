namespace DBApps.EditForm
{
    partial class FormRevEdit
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
            System.Windows.Forms.Label revenueIDLabel;
            System.Windows.Forms.Label revenueDateLabel;
            System.Windows.Forms.Label revenueUserLabel;
            System.Windows.Forms.Label revenueTypeLabel;
            System.Windows.Forms.Label revenuePriceLabel;
            System.Windows.Forms.Label movieIDLabel;
            this.movieDBDataSet = new DBApps.MovieDBDataSet();
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.revenueTableAdapter = new DBApps.MovieDBDataSetTableAdapters.RevenueTableAdapter();
            this.tableAdapterManager = new DBApps.MovieDBDataSetTableAdapters.TableAdapterManager();
            this.revenueDataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimeRevDate = new System.Windows.Forms.DateTimePicker();
            this.textRevID = new System.Windows.Forms.TextBox();
            this.textRevUser = new System.Windows.Forms.TextBox();
            this.textMovieID = new System.Windows.Forms.TextBox();
            this.textRevPrice = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            revenueIDLabel = new System.Windows.Forms.Label();
            revenueDateLabel = new System.Windows.Forms.Label();
            revenueUserLabel = new System.Windows.Forms.Label();
            revenueTypeLabel = new System.Windows.Forms.Label();
            revenuePriceLabel = new System.Windows.Forms.Label();
            movieIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // revenueIDLabel
            // 
            revenueIDLabel.AutoSize = true;
            revenueIDLabel.Location = new System.Drawing.Point(38, 243);
            revenueIDLabel.Name = "revenueIDLabel";
            revenueIDLabel.Size = new System.Drawing.Size(91, 21);
            revenueIDLabel.TabIndex = 1;
            revenueIDLabel.Text = "Revenue ID:";
            // 
            // revenueDateLabel
            // 
            revenueDateLabel.AutoSize = true;
            revenueDateLabel.Location = new System.Drawing.Point(21, 279);
            revenueDateLabel.Name = "revenueDateLabel";
            revenueDateLabel.Size = new System.Drawing.Size(109, 21);
            revenueDateLabel.TabIndex = 3;
            revenueDateLabel.Text = "Revenue Date:";
            // 
            // revenueUserLabel
            // 
            revenueUserLabel.AutoSize = true;
            revenueUserLabel.Location = new System.Drawing.Point(5, 313);
            revenueUserLabel.Name = "revenueUserLabel";
            revenueUserLabel.Size = new System.Drawing.Size(125, 21);
            revenueUserLabel.TabIndex = 5;
            revenueUserLabel.Text = "Revenue Source:";
            // 
            // revenueTypeLabel
            // 
            revenueTypeLabel.AutoSize = true;
            revenueTypeLabel.Location = new System.Drawing.Point(327, 243);
            revenueTypeLabel.Name = "revenueTypeLabel";
            revenueTypeLabel.Size = new System.Drawing.Size(108, 21);
            revenueTypeLabel.TabIndex = 7;
            revenueTypeLabel.Text = "Revenue Type:";
            // 
            // revenuePriceLabel
            // 
            revenuePriceLabel.AutoSize = true;
            revenuePriceLabel.Location = new System.Drawing.Point(327, 278);
            revenuePriceLabel.Name = "revenuePriceLabel";
            revenuePriceLabel.Size = new System.Drawing.Size(111, 21);
            revenuePriceLabel.TabIndex = 9;
            revenuePriceLabel.Text = "Revenue Price:";
            // 
            // movieIDLabel
            // 
            movieIDLabel.AutoSize = true;
            movieIDLabel.Location = new System.Drawing.Point(360, 313);
            movieIDLabel.Name = "movieIDLabel";
            movieIDLabel.Size = new System.Drawing.Size(75, 21);
            movieIDLabel.TabIndex = 11;
            movieIDLabel.Text = "Movie ID:";
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.revenueDataGridView.DataSource = this.revenueBindingSource;
            this.revenueDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.revenueDataGridView.Location = new System.Drawing.Point(0, 0);
            this.revenueDataGridView.Name = "revenueDataGridView";
            this.revenueDataGridView.Size = new System.Drawing.Size(652, 220);
            this.revenueDataGridView.TabIndex = 1;
            this.revenueDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.revenueDataGridView_RowHeaderMouseClick);
            // 
            // dateTimeRevDate
            // 
            this.dateTimeRevDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeRevDate.Location = new System.Drawing.Point(136, 273);
            this.dateTimeRevDate.Name = "dateTimeRevDate";
            this.dateTimeRevDate.Size = new System.Drawing.Size(185, 29);
            this.dateTimeRevDate.TabIndex = 12;
            // 
            // textRevID
            // 
            this.textRevID.Location = new System.Drawing.Point(136, 238);
            this.textRevID.Name = "textRevID";
            this.textRevID.Size = new System.Drawing.Size(185, 29);
            this.textRevID.TabIndex = 13;
            // 
            // textRevUser
            // 
            this.textRevUser.Location = new System.Drawing.Point(135, 310);
            this.textRevUser.Name = "textRevUser";
            this.textRevUser.Size = new System.Drawing.Size(185, 29);
            this.textRevUser.TabIndex = 13;
            // 
            // textMovieID
            // 
            this.textMovieID.Location = new System.Drawing.Point(441, 310);
            this.textMovieID.Name = "textMovieID";
            this.textMovieID.Size = new System.Drawing.Size(185, 29);
            this.textMovieID.TabIndex = 13;
            // 
            // textRevPrice
            // 
            this.textRevPrice.Location = new System.Drawing.Point(441, 276);
            this.textRevPrice.Name = "textRevPrice";
            this.textRevPrice.Size = new System.Drawing.Size(185, 29);
            this.textRevPrice.TabIndex = 13;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(318, 365);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(87, 38);
            this.buttonDelete.TabIndex = 35;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(225, 365);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(87, 38);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(132, 365);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(87, 38);
            this.buttonInsert.TabIndex = 37;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(411, 365);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 38);
            this.buttonClear.TabIndex = 38;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RevenueID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RevenueID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RevenueDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "RevenueDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RevenueUser";
            this.dataGridViewTextBoxColumn3.HeaderText = "RevenueSource";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RevenueType";
            this.dataGridViewTextBoxColumn4.HeaderText = "RevenueType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RevenuePrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "RevenuePrice";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MovieID";
            this.dataGridViewTextBoxColumn6.HeaderText = "MovieID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "รายรับ",
            "รายจ่าย"});
            this.comboBox1.Location = new System.Drawing.Point(441, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 29);
            this.comboBox1.TabIndex = 39;
            // 
            // FormRevEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 434);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textRevPrice);
            this.Controls.Add(this.textMovieID);
            this.Controls.Add(this.textRevUser);
            this.Controls.Add(this.textRevID);
            this.Controls.Add(this.dateTimeRevDate);
            this.Controls.Add(revenueIDLabel);
            this.Controls.Add(revenueDateLabel);
            this.Controls.Add(revenueUserLabel);
            this.Controls.Add(revenueTypeLabel);
            this.Controls.Add(revenuePriceLabel);
            this.Controls.Add(movieIDLabel);
            this.Controls.Add(this.revenueDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRevEdit";
            this.Text = "FormRevEdit";
            this.Load += new System.EventHandler(this.FormRevEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private MovieDBDataSetTableAdapters.RevenueTableAdapter revenueTableAdapter;
        private MovieDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView revenueDataGridView;
        private System.Windows.Forms.DateTimePicker dateTimeRevDate;
        private System.Windows.Forms.TextBox textRevID;
        private System.Windows.Forms.TextBox textRevUser;
        private System.Windows.Forms.TextBox textMovieID;
        private System.Windows.Forms.TextBox textRevPrice;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}