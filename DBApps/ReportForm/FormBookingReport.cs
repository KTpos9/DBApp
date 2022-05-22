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
    public partial class FormBookingReport : Form
    {
        public FormBookingReport()
        {
            InitializeComponent();
        }

        private void FormBookingReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.movieDBDataSet.Booking);

            this.reportViewer1.RefreshReport();
        }
    }
}
