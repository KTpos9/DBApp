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
    public partial class FormRevReport : Form
    {
        public FormRevReport()
        {
            InitializeComponent();
        }

        private void FormRevReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.Revenue' table. You can move, or remove it, as needed.
            this.revenueTableAdapter.Fill(this.movieDBDataSet.Revenue);

            this.reportViewer1.RefreshReport();
        }
    }
}
