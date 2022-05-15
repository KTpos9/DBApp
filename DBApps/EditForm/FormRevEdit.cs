using System;
using System.Windows.Forms;

namespace DBApps.EditForm
{
    public partial class FormRevEdit : Form
    {
        public FormRevEdit()
        {
            InitializeComponent();
        }

        private void FormRevEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.Revenue' table. You can move, or remove it, as needed.
            this.revenueTableAdapter.Fill(this.movieDBDataSet.Revenue);

        }

        private void revenueDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textRevID.Text = revenueDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimeRevDate.Value = Convert.ToDateTime(revenueDataGridView.Rows[e.RowIndex].Cells[1].Value);
            textRevUser.Text = revenueDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            textRevType.Text = revenueDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            textRevPrice.Text = revenueDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            textMovieID.Text = revenueDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.revenueTableAdapter.Insert(textRevID.Text, dateTimeRevDate.Value.Date, textRevUser.Text, textRevType.Text, Convert.ToInt32(textRevPrice.Text), textMovieID.Text);
            this.revenueTableAdapter.Fill(this.movieDBDataSet.Revenue);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.revenueTableAdapter.Update1(dateTimeRevDate.Value.Date, textRevUser.Text, textRevType.Text, Convert.ToInt32(textRevPrice.Text), textMovieID.Text, textRevID.Text);
            this.revenueTableAdapter.Fill(this.movieDBDataSet.Revenue);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.revenueTableAdapter.Delete(textRevID.Text, dateTimeRevDate.Value, textRevUser.Text, textRevType.Text, Convert.ToInt32(textRevPrice.Text), textMovieID.Text);
            this.revenueTableAdapter.Fill(this.movieDBDataSet.Revenue);
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
