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
            await moviedb.Movies.LoadAsync();
            movieBindingSource.DataSource = moviedb.Movies.Local;
        }
    }
}
