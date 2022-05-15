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
            labelTotal.Text = movieDBDataSet.Revenue.Compute("SUM(RevenuePrice)", string.Empty).ToString();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == false)
            {
                this.revenueDataGridView.Columns[checkBox.Text].Visible = false;
                return;
            }
            this.revenueDataGridView.Columns[checkBox.Text].Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.revenueDataGridView.Sort(revenueDataGridView.Columns[comboBox1.SelectedIndex], ListSortDirection.Ascending);
        }
    }
}
