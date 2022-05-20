using System;
using System.Windows.Forms;

namespace DBApps.EditForm
{
    public partial class FormMSEdit : Form
    {
        public FormMSEdit()
        {
            InitializeComponent();
        }


        private void FormMSEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.MovieSchedule' table. You can move, or remove it, as needed.
            this.movieScheduleTableAdapter.Fill(this.movieDBDataSet.MovieSchedule);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.movieScheduleTableAdapter.Insert(textMSID.Text, TimePicker.Value.TimeOfDay.ToString(),dateTimePicker1.Value.Date,Convert.ToInt32(textAdd.Text),textMovieID.Text);
            this.movieScheduleTableAdapter.Fill(this.movieDBDataSet.MovieSchedule);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.movieScheduleTableAdapter.Update1(TimePicker.Value.TimeOfDay.ToString(), dateTimePicker1.Value.Date, Convert.ToInt32(textAdd.Text), textMovieID.Text,textMSID.Text);
            this.movieScheduleTableAdapter.Fill(this.movieDBDataSet.MovieSchedule);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.movieScheduleTableAdapter.Delete(textMSID.Text, TimePicker.Value.TimeOfDay.ToString(), dateTimePicker1.Value.Date, Convert.ToInt32(textAdd.Text), textMovieID.Text);
            this.movieScheduleTableAdapter.Fill(this.movieDBDataSet.MovieSchedule);
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

        private void movieScheduleDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textMSID.Text = movieScheduleDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            TimePicker.Value = (DateTime)movieScheduleDataGridView.Rows[e.RowIndex].Cells[1].Value;
            dateTimePicker1.Value = (DateTime)movieScheduleDataGridView.Rows[e.RowIndex].Cells[2].Value;
            textAdd.Text = movieScheduleDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            textMovieID.Text = movieScheduleDataGridView.Rows[e.RowIndex ].Cells[4].Value.ToString();
        }
    }
}
