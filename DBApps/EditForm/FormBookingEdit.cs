using System;
using System.Windows.Forms;

namespace DBApps.EditForm
{
    public partial class FormBookingEdit : Form
    {
        public FormBookingEdit()
        {
            InitializeComponent();
        }

        private void FormBookingEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.movieDBDataSet.Booking);
        }

        private void bookingDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBookingID.Text = bookingDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            textCusID.Text = bookingDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            textMSID.Text = bookingDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBookingNum.Text = bookingDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            textMovieName.Text = bookingDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBookingCinemaNo.Text = bookingDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            bookingTableAdapter.Insert(textBookingID.Text, textCusID.Text, textMSID.Text, textBookingNum.Text, textMovieName.Text, Convert.ToInt32(textBookingCinemaNo.Text));
            this.bookingTableAdapter.Fill(this.movieDBDataSet.Booking);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.bookingTableAdapter.Update1(textCusID.Text, textMSID.Text, textBookingNum.Text, textMovieName.Text, Convert.ToInt32(textBookingCinemaNo.Text), textBookingID.Text);
            this.bookingTableAdapter.Fill(this.movieDBDataSet.Booking);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.bookingTableAdapter.Delete(textBookingID.Text, textCusID.Text, textMSID.Text, textBookingNum.Text, textMovieName.Text, Convert.ToInt32(textBookingCinemaNo.Text));
            this.bookingTableAdapter.Fill(this.movieDBDataSet.Booking);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }
    }
}
