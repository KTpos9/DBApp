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
    public partial class FormEmpEdit : Form
    {
        public FormEmpEdit()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDBDataSet);
        }

        private void FormEmpEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.movieDBDataSet.Employee);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }

        private void employeeDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textEmpID.Text = employeeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            textEmpPass.Text = employeeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            textEmpSalary.Text = employeeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            textEmpPositionID.Text = employeeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboEmpPosition.Text = employeeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            textEmpName.Text = employeeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            textEmpSName.Text = employeeDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            textEmpHouseNum.Text = employeeDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            textEmpMoo.Text = employeeDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            textEmpSD.Text = employeeDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            textEmpDistrict.Text = employeeDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
            textEmpProvince.Text = employeeDataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
            textEmpPostalCode.Text = employeeDataGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
            textMovieID.Text = employeeDataGridView.Rows[e.RowIndex].Cells[13].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Delete1(employeeDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.employeeTableAdapter.Fill(this.movieDBDataSet.Employee);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Insert(textEmpID.Text, textEmpPass.Text, Convert.ToInt32(textEmpSalary.Text), textEmpPositionID.Text, comboEmpPosition.Text, textEmpName.Text, textEmpSName.Text, textEmpHouseNum.Text, textEmpMoo.Text, textEmpSD.Text, textEmpDistrict.Text, textEmpProvince.Text, Convert.ToInt32(textEmpPostalCode.Text), textMovieID.Text);
            this.employeeTableAdapter.Fill(this.movieDBDataSet.Employee);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Update1(textEmpPass.Text, Convert.ToInt32(textEmpSalary.Text), textEmpPositionID.Text, comboEmpPosition.Text, textEmpName.Text, textEmpSName.Text, textEmpHouseNum.Text, textEmpMoo.Text, textEmpSD.Text, textEmpDistrict.Text, textEmpProvince.Text, Convert.ToInt32(textEmpPostalCode.Text), textMovieID.Text,textEmpID.Text);
            this.employeeTableAdapter.Fill(this.movieDBDataSet.Employee);
        }
    }
}
