using System;
using System.Windows.Forms;
namespace DBApps.Forms
{
    public partial class information : Form
    {
        public information()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           Form form = new QueryForm.FormRevQuery();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new FormEmpQuery();
            form.Show();
        }

        private void buttonMovie_Click(object sender, EventArgs e)
        {
            Form form = new QueryForm.FormMovieQuery();
            form.Show();
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            Form form = new QueryForm.FormMSQuery();
            form.Show();
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            Form form = new QueryForm.FormBooking();
            form.Show();
        }
    }
}
