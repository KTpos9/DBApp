using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApps.QueryForm
{
    public partial class FormRevQuery : Form
    {
        public FormRevQuery()
        {
            InitializeComponent();
        }

        private void revenueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.revenueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDBDataSet);

        }

        private void FormRevQuery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.Revenue' table. You can move, or remove it, as needed.
            this.revenueTableAdapter.Fill(this.movieDBDataSet.Revenue);

        }
    }
}
