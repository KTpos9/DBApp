using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DBApps.QueryForm
{
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.movieDBDataSet.Booking);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == false)
            {
                this.bookingDataGridView.Columns[checkBox.Text].Visible = false;
                return;
            }
            this.bookingDataGridView.Columns[checkBox.Text].Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bookingDataGridView.Sort(bookingDataGridView.Columns[comboBox1.SelectedIndex], ListSortDirection.Ascending);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Export.ExportToExcel(bookingDataGridView);
        }
    }
}
