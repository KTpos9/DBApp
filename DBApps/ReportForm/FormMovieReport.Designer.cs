﻿namespace DBApps.ReportForm
{
    partial class FormMovieReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.movieDBDataSet = new DBApps.MovieDBDataSet();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter = new DBApps.MovieDBDataSetTableAdapters.MovieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MovieDataSet";
            reportDataSource1.Value = this.movieBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBApps.Report.ReportMovie.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(753, 407);
            this.reportViewer1.TabIndex = 0;
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
            // FormMovieReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 407);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMovieReport";
            this.Text = "FormMovieReport";
            this.Load += new System.EventHandler(this.FormMovieReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MovieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private MovieDBDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
    }
}