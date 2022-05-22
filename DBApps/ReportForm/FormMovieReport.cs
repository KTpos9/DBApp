using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApps.ReportForm
{
    public partial class FormMovieReport : Form
    {
        public FormMovieReport()
        {
            InitializeComponent();
        }

        private void FormMovieReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.movieDBDataSet.Movie);

            this.reportViewer1.RefreshReport();
        }
    }
}
