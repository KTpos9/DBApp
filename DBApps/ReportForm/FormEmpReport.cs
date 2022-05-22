using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApps
{
    public partial class FormEmpReport : Form
    {
        public FormEmpReport()
        {
            InitializeComponent();
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.movieDBDataSet.Employee);
            //this.employeeTableAdapter.Fill(this.movieDBDataSet.Employee);
            this.reportViewer1.RefreshReport();
        }
    }
}
