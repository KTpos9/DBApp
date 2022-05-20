namespace DBApps.EditForm
{
    partial class FormMovieEdit
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
            System.Windows.Forms.Label movieIDLabel;
            System.Windows.Forms.Label moviePriceLabel;
            System.Windows.Forms.Label movieNameLabel;
            System.Windows.Forms.Label movieCategoryLabel;
            System.Windows.Forms.Label movieDateLabel;
            this.textMovieID = new System.Windows.Forms.TextBox();
            this.textMoviePrice = new System.Windows.Forms.TextBox();
            this.textMovieName = new System.Windows.Forms.TextBox();
            this.textMovieCategory = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.movieDBDataSet = new DBApps.MovieDBDataSet();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter = new DBApps.MovieDBDataSetTableAdapters.MovieTableAdapter();
            this.tableAdapterManager = new DBApps.MovieDBDataSetTableAdapters.TableAdapterManager();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeMovieDate = new System.Windows.Forms.DateTimePicker();
            movieIDLabel = new System.Windows.Forms.Label();
            moviePriceLabel = new System.Windows.Forms.Label();
            movieNameLabel = new System.Windows.Forms.Label();
            movieCategoryLabel = new System.Windows.Forms.Label();
            movieDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // movieIDLabel
            // 
            movieIDLabel.AutoSize = true;
            movieIDLabel.Location = new System.Drawing.Point(39, 265);
            movieIDLabel.Name = "movieIDLabel";
            movieIDLabel.Size = new System.Drawing.Size(75, 21);
            movieIDLabel.TabIndex = 2;
            movieIDLabel.Text = "Movie ID:";
            // 
            // moviePriceLabel
            // 
            moviePriceLabel.AutoSize = true;
            moviePriceLabel.Location = new System.Drawing.Point(19, 300);
            moviePriceLabel.Name = "moviePriceLabel";
            moviePriceLabel.Size = new System.Drawing.Size(95, 21);
            moviePriceLabel.TabIndex = 4;
            moviePriceLabel.Text = "Movie Price:";
            // 
            // movieNameLabel
            // 
            movieNameLabel.AutoSize = true;
            movieNameLabel.Location = new System.Drawing.Point(12, 335);
            movieNameLabel.Name = "movieNameLabel";
            movieNameLabel.Size = new System.Drawing.Size(102, 21);
            movieNameLabel.TabIndex = 6;
            movieNameLabel.Text = "Movie Name:";
            // 
            // movieCategoryLabel
            // 
            movieCategoryLabel.AutoSize = true;
            movieCategoryLabel.Location = new System.Drawing.Point(285, 265);
            movieCategoryLabel.Name = "movieCategoryLabel";
            movieCategoryLabel.Size = new System.Drawing.Size(125, 21);
            movieCategoryLabel.TabIndex = 8;
            movieCategoryLabel.Text = "Movie Category:";
            // 
            // movieDateLabel
            // 
            movieDateLabel.AutoSize = true;
            movieDateLabel.Location = new System.Drawing.Point(317, 300);
            movieDateLabel.Name = "movieDateLabel";
            movieDateLabel.Size = new System.Drawing.Size(93, 21);
            movieDateLabel.TabIndex = 10;
            movieDateLabel.Text = "Movie Date:";
            // 
            // textMovieID
            // 
            this.textMovieID.Location = new System.Drawing.Point(120, 262);
            this.textMovieID.Name = "textMovieID";
            this.textMovieID.Size = new System.Drawing.Size(159, 29);
            this.textMovieID.TabIndex = 11;
            // 
            // textMoviePrice
            // 
            this.textMoviePrice.Location = new System.Drawing.Point(120, 297);
            this.textMoviePrice.Name = "textMoviePrice";
            this.textMoviePrice.Size = new System.Drawing.Size(159, 29);
            this.textMoviePrice.TabIndex = 11;
            // 
            // textMovieName
            // 
            this.textMovieName.Location = new System.Drawing.Point(120, 332);
            this.textMovieName.Name = "textMovieName";
            this.textMovieName.Size = new System.Drawing.Size(159, 29);
            this.textMovieName.TabIndex = 11;
            // 
            // textMovieCategory
            // 
            this.textMovieCategory.Location = new System.Drawing.Point(416, 262);
            this.textMovieCategory.Name = "textMovieCategory";
            this.textMovieCategory.Size = new System.Drawing.Size(159, 29);
            this.textMovieCategory.TabIndex = 11;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(306, 394);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(87, 38);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(213, 394);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(87, 38);
            this.buttonUpdate.TabIndex = 32;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(120, 394);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(87, 38);
            this.buttonInsert.TabIndex = 33;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(399, 394);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 38);
            this.buttonClear.TabIndex = 34;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // movieDBDataSet
            // 
            this.movieDBDataSet.DataSetName = "MovieDBDataSet";
            this.movieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.movieDBDataSet;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.MovieScheduleTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.RevenueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DBApps.MovieDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.AutoGenerateColumns = false;
            this.movieDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.movieDataGridView.DataSource = this.movieBindingSource;
            this.movieDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.movieDataGridView.Location = new System.Drawing.Point(0, 0);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.Size = new System.Drawing.Size(595, 229);
            this.movieDataGridView.TabIndex = 35;
            this.movieDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.movieDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MovieID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MovieID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MoviePrice";
            this.dataGridViewTextBoxColumn2.HeaderText = "MoviePrice";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MovieName";
            this.dataGridViewTextBoxColumn3.HeaderText = "MovieName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MovieCategory";
            this.dataGridViewTextBoxColumn4.HeaderText = "MovieCategory";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MovieDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "MovieDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dateTimeMovieDate
            // 
            this.dateTimeMovieDate.Location = new System.Drawing.Point(417, 300);
            this.dateTimeMovieDate.Name = "dateTimeMovieDate";
            this.dateTimeMovieDate.Size = new System.Drawing.Size(158, 29);
            this.dateTimeMovieDate.TabIndex = 36;
            // 
            // FormMovieEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 472);
            this.Controls.Add(this.dateTimeMovieDate);
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textMovieCategory);
            this.Controls.Add(this.textMovieName);
            this.Controls.Add(this.textMoviePrice);
            this.Controls.Add(this.textMovieID);
            this.Controls.Add(movieIDLabel);
            this.Controls.Add(moviePriceLabel);
            this.Controls.Add(movieNameLabel);
            this.Controls.Add(movieCategoryLabel);
            this.Controls.Add(movieDateLabel);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMovieEdit";
            this.Text = "FormMovieEdit";
            this.Load += new System.EventHandler(this.FormMovieEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textMovieID;
        private System.Windows.Forms.TextBox textMoviePrice;
        private System.Windows.Forms.TextBox textMovieName;
        private System.Windows.Forms.TextBox textMovieCategory;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonClear;
        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private MovieDBDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private MovieDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DateTimePicker dateTimeMovieDate;
    }
}