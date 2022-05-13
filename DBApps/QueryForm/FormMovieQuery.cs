using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApps.QueryForm
{
    public partial class FormMovieQuery : Form
    {
        public FormMovieQuery()
        {
            InitializeComponent();
        }
        MovieDBEntities moviedb = new MovieDBEntities();

        private async void FormMovieQuery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.movieDBDataSet.Movie);

            // await moviedb.Movies.LoadAsync();
            //  movieBindingSource.DataSource = moviedb.Movies.Local;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == false)
            {
                this.movieDataGridView.Columns[checkBox.Text].Visible = false;
                return;
            }
            this.movieDataGridView.Columns[checkBox.Text].Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.movieDataGridView.Sort(movieDataGridView.Columns[comboBox1.SelectedIndex], ListSortDirection.Ascending);
        }
    }
}
