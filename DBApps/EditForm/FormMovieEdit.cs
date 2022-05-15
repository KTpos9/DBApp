using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApps.EditForm
{
    public partial class FormMovieEdit : Form
    {
        public FormMovieEdit()
        {
            InitializeComponent();
        }

        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDBDataSet);

        }

        private void FormMovieEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.movieDBDataSet.Movie);
            // TODO: This line of code loads data into the 'movieDBDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.movieDBDataSet.Movie);
            // TODO: This line of code loads data into the 'movieDBDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.movieDBDataSet.Movie);
        }

        private void movieDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textMovieID.Text = movieDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            textMoviePrice.Text = movieDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            textMovieName.Text = movieDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            textMovieCategory.Text = movieDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            textmovieDate.Text = movieDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.Insert(textMovieID.Text,Convert.ToInt32(textMoviePrice.Text), textMovieName.Text, textMovieCategory.Text, Convert.ToDateTime(textmovieDate.Text));
            this.movieTableAdapter.Fill(this.movieDBDataSet.Movie);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.Update1(Convert.ToInt32(textMoviePrice.Text), textMovieName.Text, textMovieCategory.Text, Convert.ToDateTime(textmovieDate.Text), textMovieID.Text);
            this.movieTableAdapter.Fill(this.movieDBDataSet.Movie);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.Delete(textMovieID.Text, Convert.ToInt32(textMoviePrice.Text), textMovieName.Text, textMovieCategory.Text, Convert.ToDateTime(textmovieDate.Text));
            this.movieTableAdapter.Fill(this.movieDBDataSet.Movie);
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

        private void movieBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDBDataSet);
            
        }

        private void movieBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDBDataSet);

        }
    }
}
