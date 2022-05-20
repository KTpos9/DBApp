namespace DBApps.EditForm
{
    partial class FormBookingEdit
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
            System.Windows.Forms.Label bookingIDLabel;
            System.Windows.Forms.Label cusIDLabel;
            System.Windows.Forms.Label mSIDLabel;
            System.Windows.Forms.Label bookingNumLabel;
            System.Windows.Forms.Label movieNameLabel;
            System.Windows.Forms.Label bookingCinemaNoLabel;
            this.movieDBDataSet = new DBApps.MovieDBDataSet();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new DBApps.MovieDBDataSetTableAdapters.BookingTableAdapter();
            this.tableAdapterManager = new DBApps.MovieDBDataSetTableAdapters.TableAdapterManager();
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBookingID = new System.Windows.Forms.TextBox();
            this.textCusID = new System.Windows.Forms.TextBox();
            this.textMSID = new System.Windows.Forms.TextBox();
            this.textBookingNum = new System.Windows.Forms.TextBox();
            this.textMovieName = new System.Windows.Forms.TextBox();
            this.textBookingCinemaNo = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            bookingIDLabel = new System.Windows.Forms.Label();
            cusIDLabel = new System.Windows.Forms.Label();
            mSIDLabel = new System.Windows.Forms.Label();
            bookingNumLabel = new System.Windows.Forms.Label();
            movieNameLabel = new System.Windows.Forms.Label();
            bookingCinemaNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // movieDBDataSet
            // 
            this.movieDBDataSet.DataSetName = "MovieDBDataSet";
            this.movieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.movieDBDataSet;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = this.bookingTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.MovieScheduleTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.RevenueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DBApps.MovieDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AutoGenerateColumns = false;
            this.bookingDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.bookingDataGridView.DataSource = this.bookingBindingSource;
            this.bookingDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingDataGridView.Location = new System.Drawing.Point(0, 0);
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.Size = new System.Drawing.Size(654, 220);
            this.bookingDataGridView.TabIndex = 1;
            this.bookingDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bookingDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookingID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BookingID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CusID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CusID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MSID";
            this.dataGridViewTextBoxColumn3.HeaderText = "MSID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BookingNum";
            this.dataGridViewTextBoxColumn4.HeaderText = "BookingNum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MovieName";
            this.dataGridViewTextBoxColumn5.HeaderText = "MovieName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BookingCinemaNo";
            this.dataGridViewTextBoxColumn6.HeaderText = "BookingCinemaNo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bookingIDLabel
            // 
            bookingIDLabel.AutoSize = true;
            bookingIDLabel.Location = new System.Drawing.Point(12, 238);
            bookingIDLabel.Name = "bookingIDLabel";
            bookingIDLabel.Size = new System.Drawing.Size(89, 21);
            bookingIDLabel.TabIndex = 1;
            bookingIDLabel.Text = "Booking ID:";
            // 
            // cusIDLabel
            // 
            cusIDLabel.AutoSize = true;
            cusIDLabel.Location = new System.Drawing.Point(42, 273);
            cusIDLabel.Name = "cusIDLabel";
            cusIDLabel.Size = new System.Drawing.Size(59, 21);
            cusIDLabel.TabIndex = 3;
            cusIDLabel.Text = "Cus ID:";
            // 
            // mSIDLabel
            // 
            mSIDLabel.AutoSize = true;
            mSIDLabel.Location = new System.Drawing.Point(50, 308);
            mSIDLabel.Name = "mSIDLabel";
            mSIDLabel.Size = new System.Drawing.Size(51, 21);
            mSIDLabel.TabIndex = 5;
            mSIDLabel.Text = "MSID:";
            // 
            // bookingNumLabel
            // 
            bookingNumLabel.AutoSize = true;
            bookingNumLabel.Location = new System.Drawing.Point(340, 243);
            bookingNumLabel.Name = "bookingNumLabel";
            bookingNumLabel.Size = new System.Drawing.Size(109, 21);
            bookingNumLabel.TabIndex = 7;
            bookingNumLabel.Text = "Booking Num:";
            // 
            // movieNameLabel
            // 
            movieNameLabel.AutoSize = true;
            movieNameLabel.Location = new System.Drawing.Point(347, 278);
            movieNameLabel.Name = "movieNameLabel";
            movieNameLabel.Size = new System.Drawing.Size(102, 21);
            movieNameLabel.TabIndex = 9;
            movieNameLabel.Text = "Movie Name:";
            // 
            // bookingCinemaNoLabel
            // 
            bookingCinemaNoLabel.AutoSize = true;
            bookingCinemaNoLabel.Location = new System.Drawing.Point(296, 313);
            bookingCinemaNoLabel.Name = "bookingCinemaNoLabel";
            bookingCinemaNoLabel.Size = new System.Drawing.Size(153, 21);
            bookingCinemaNoLabel.TabIndex = 11;
            bookingCinemaNoLabel.Text = "Booking Cinema No:";
            // 
            // textBookingID
            // 
            this.textBookingID.Location = new System.Drawing.Point(107, 235);
            this.textBookingID.Name = "textBookingID";
            this.textBookingID.Size = new System.Drawing.Size(163, 29);
            this.textBookingID.TabIndex = 12;
            // 
            // textCusID
            // 
            this.textCusID.Location = new System.Drawing.Point(107, 270);
            this.textCusID.Name = "textCusID";
            this.textCusID.Size = new System.Drawing.Size(163, 29);
            this.textCusID.TabIndex = 12;
            // 
            // textMSID
            // 
            this.textMSID.Location = new System.Drawing.Point(107, 305);
            this.textMSID.Name = "textMSID";
            this.textMSID.Size = new System.Drawing.Size(163, 29);
            this.textMSID.TabIndex = 12;
            // 
            // textBookingNum
            // 
            this.textBookingNum.Location = new System.Drawing.Point(455, 240);
            this.textBookingNum.Name = "textBookingNum";
            this.textBookingNum.Size = new System.Drawing.Size(163, 29);
            this.textBookingNum.TabIndex = 12;
            // 
            // textMovieName
            // 
            this.textMovieName.Location = new System.Drawing.Point(455, 275);
            this.textMovieName.Name = "textMovieName";
            this.textMovieName.Size = new System.Drawing.Size(163, 29);
            this.textMovieName.TabIndex = 12;
            // 
            // textBookingCinemaNo
            // 
            this.textBookingCinemaNo.Location = new System.Drawing.Point(455, 310);
            this.textBookingCinemaNo.Name = "textBookingCinemaNo";
            this.textBookingCinemaNo.Size = new System.Drawing.Size(163, 29);
            this.textBookingCinemaNo.TabIndex = 12;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(319, 366);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(87, 38);
            this.buttonDelete.TabIndex = 39;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(226, 366);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(87, 38);
            this.buttonUpdate.TabIndex = 40;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(133, 366);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(87, 38);
            this.buttonInsert.TabIndex = 41;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(412, 366);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 38);
            this.buttonClear.TabIndex = 42;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormBookingEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 429);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBookingCinemaNo);
            this.Controls.Add(this.textMSID);
            this.Controls.Add(this.textMovieName);
            this.Controls.Add(this.textCusID);
            this.Controls.Add(this.textBookingNum);
            this.Controls.Add(this.textBookingID);
            this.Controls.Add(bookingIDLabel);
            this.Controls.Add(cusIDLabel);
            this.Controls.Add(mSIDLabel);
            this.Controls.Add(bookingNumLabel);
            this.Controls.Add(movieNameLabel);
            this.Controls.Add(bookingCinemaNoLabel);
            this.Controls.Add(this.bookingDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBookingEdit";
            this.Text = "FormBookingEdit";
            this.Load += new System.EventHandler(this.FormBookingEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private MovieDBDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private MovieDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBookingID;
        private System.Windows.Forms.TextBox textCusID;
        private System.Windows.Forms.TextBox textMSID;
        private System.Windows.Forms.TextBox textBookingNum;
        private System.Windows.Forms.TextBox textMovieName;
        private System.Windows.Forms.TextBox textBookingCinemaNo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonClear;
    }
}