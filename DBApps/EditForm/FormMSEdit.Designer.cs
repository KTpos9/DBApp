namespace DBApps.EditForm
{
    partial class FormMSEdit
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
            System.Windows.Forms.Label mSIDLabel;
            System.Windows.Forms.Label mSDateLabel;
            System.Windows.Forms.Label mSAddLabel;
            System.Windows.Forms.Label movieIDLabel;
            System.Windows.Forms.Label mSTimeLabel;
            this.textMSID = new System.Windows.Forms.TextBox();
            this.textAdd = new System.Windows.Forms.TextBox();
            this.textMovieID = new System.Windows.Forms.TextBox();
            this.movieDBDataSet = new DBApps.MovieDBDataSet();
            this.movieScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieScheduleTableAdapter = new DBApps.MovieDBDataSetTableAdapters.MovieScheduleTableAdapter();
            this.tableAdapterManager = new DBApps.MovieDBDataSetTableAdapters.TableAdapterManager();
            this.movieScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            mSIDLabel = new System.Windows.Forms.Label();
            mSDateLabel = new System.Windows.Forms.Label();
            mSAddLabel = new System.Windows.Forms.Label();
            movieIDLabel = new System.Windows.Forms.Label();
            mSTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mSIDLabel
            // 
            mSIDLabel.AutoSize = true;
            mSIDLabel.Location = new System.Drawing.Point(36, 238);
            mSIDLabel.Name = "mSIDLabel";
            mSIDLabel.Size = new System.Drawing.Size(51, 21);
            mSIDLabel.TabIndex = 1;
            mSIDLabel.Text = "MSID:";
            // 
            // mSDateLabel
            // 
            mSDateLabel.AutoSize = true;
            mSDateLabel.Location = new System.Drawing.Point(16, 308);
            mSDateLabel.Name = "mSDateLabel";
            mSDateLabel.Size = new System.Drawing.Size(69, 21);
            mSDateLabel.TabIndex = 5;
            mSDateLabel.Text = "MSDate:";
            // 
            // mSAddLabel
            // 
            mSAddLabel.AutoSize = true;
            mSAddLabel.Location = new System.Drawing.Point(278, 238);
            mSAddLabel.Name = "mSAddLabel";
            mSAddLabel.Size = new System.Drawing.Size(64, 21);
            mSAddLabel.TabIndex = 7;
            mSAddLabel.Text = "MSAdd:";
            // 
            // movieIDLabel
            // 
            movieIDLabel.AutoSize = true;
            movieIDLabel.Location = new System.Drawing.Point(271, 273);
            movieIDLabel.Name = "movieIDLabel";
            movieIDLabel.Size = new System.Drawing.Size(75, 21);
            movieIDLabel.TabIndex = 9;
            movieIDLabel.Text = "Movie ID:";
            // 
            // mSTimeLabel
            // 
            mSTimeLabel.AutoSize = true;
            mSTimeLabel.Location = new System.Drawing.Point(18, 273);
            mSTimeLabel.Name = "mSTimeLabel";
            mSTimeLabel.Size = new System.Drawing.Size(70, 21);
            mSTimeLabel.TabIndex = 3;
            mSTimeLabel.Text = "MSTime:";
            // 
            // textMSID
            // 
            this.textMSID.Location = new System.Drawing.Point(93, 235);
            this.textMSID.Name = "textMSID";
            this.textMSID.Size = new System.Drawing.Size(145, 29);
            this.textMSID.TabIndex = 10;
            // 
            // textAdd
            // 
            this.textAdd.Location = new System.Drawing.Point(352, 235);
            this.textAdd.Name = "textAdd";
            this.textAdd.Size = new System.Drawing.Size(145, 29);
            this.textAdd.TabIndex = 10;
            // 
            // textMovieID
            // 
            this.textMovieID.Location = new System.Drawing.Point(352, 270);
            this.textMovieID.Name = "textMovieID";
            this.textMovieID.Size = new System.Drawing.Size(145, 29);
            this.textMovieID.TabIndex = 10;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.movieScheduleDataGridView.DataSource = this.movieScheduleBindingSource;
            this.movieScheduleDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.movieScheduleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.movieScheduleDataGridView.Name = "movieScheduleDataGridView";
            this.movieScheduleDataGridView.Size = new System.Drawing.Size(547, 220);
            this.movieScheduleDataGridView.TabIndex = 11;
            this.movieScheduleDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.movieScheduleDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MSID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MSID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MSTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "MSTime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MSDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "MSDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MSAdd";
            this.dataGridViewTextBoxColumn4.HeaderText = "MSAdd";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MovieID";
            this.dataGridViewTextBoxColumn5.HeaderText = "MovieID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(279, 358);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(87, 38);
            this.buttonDelete.TabIndex = 43;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(186, 358);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(87, 38);
            this.buttonUpdate.TabIndex = 44;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(93, 358);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(87, 38);
            this.buttonInsert.TabIndex = 45;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(372, 358);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 38);
            this.buttonClear.TabIndex = 46;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(92, 273);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(146, 29);
            this.TimePicker.TabIndex = 47;
            this.TimePicker.Value = new System.DateTime(2022, 5, 19, 22, 29, 34, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 302);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 29);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // FormMSEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 427);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.movieScheduleDataGridView);
            this.Controls.Add(this.textMovieID);
            this.Controls.Add(this.textAdd);
            this.Controls.Add(this.textMSID);
            this.Controls.Add(mSIDLabel);
            this.Controls.Add(mSTimeLabel);
            this.Controls.Add(mSDateLabel);
            this.Controls.Add(mSAddLabel);
            this.Controls.Add(movieIDLabel);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMSEdit";
            this.Text = "FormMSEdit";
            this.Load += new System.EventHandler(this.FormMSEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textMSID;
        private System.Windows.Forms.TextBox textAdd;
        private System.Windows.Forms.TextBox textMovieID;
        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource movieScheduleBindingSource;
        private MovieDBDataSetTableAdapters.MovieScheduleTableAdapter movieScheduleTableAdapter;
        private MovieDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView movieScheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}