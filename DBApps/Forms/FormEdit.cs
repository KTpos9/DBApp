using System;
using System.Windows.Forms;

namespace DBApps.Forms
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        private void buttonEmp_Click(object sender, EventArgs e)
        {
            Form form = new EditForm.FormEmpEdit();
            form.Show();
        }

        private void buttonMovie_Click(object sender, EventArgs e)
        {
            Form form = new EditForm.FormMovieEdit();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new EditForm.FormRevEdit();
            form.Show();
        }
        private void buttonMovieSchedule_Click(object sender, EventArgs e)
        {
            Form form = new EditForm.FormMSEdit();
            form.Show();
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            Form form = new EditForm.FormBookingEdit();
            form.Show();
        }

    }
}
