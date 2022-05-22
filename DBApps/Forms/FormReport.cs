using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApps.Forms
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void buttonRev_Click(object sender, EventArgs e)
        {
            Form form = new ReportForm.FormRevReport();
            form.Show();
        }

        private void buttonEmp_Click(object sender, EventArgs e)
        {
            Form form = new FormEmpReport();
            form.Show();
        }

        private void buttonMovie_Click(object sender, EventArgs e)
        {
            Form form = new ReportForm.FormMovieReport();
            form.Show();
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            Form form = new ReportForm.FormMSReport();
            form.Show();
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            Form form = new ReportForm.FormBookingReport();
            form.Show();
        }
    }
}
