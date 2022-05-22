using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DBApps.QueryForm
{
    public partial class FormMSQuery : Form
    {
        public FormMSQuery()
        {
            InitializeComponent();
        }

        private void FormMSQuery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.MovieSchedule' table. You can move, or remove it, as needed.
            this.movieScheduleTableAdapter.Fill(this.movieDBDataSet.MovieSchedule);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.movieScheduleDataGridView.Sort(movieScheduleDataGridView.Columns[comboBox1.SelectedIndex], ListSortDirection.Ascending);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == false)
            {
                this.movieScheduleDataGridView.Columns[checkBox.Text].Visible = false;
                return;
            }
            this.movieScheduleDataGridView.Columns[checkBox.Text].Visible = true;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Export.ExportToExcel(movieScheduleDataGridView);
        }
    }
}
