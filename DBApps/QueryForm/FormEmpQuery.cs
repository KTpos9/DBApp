using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
using DBApps.MovieDBDataSetTableAdapters;

namespace DBApps.Forms
{
    public partial class FormEmpQuery : Form
    {
        public FormEmpQuery()
        {
            InitializeComponent();
        }
        MovieDBEntities moviedb = new MovieDBEntities();
        
        private void FormEmpQuery_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.movieDBDataSet.Employee);
            //EmployeeTableAdapter EmployeeAdapter = new EmployeeTableAdapter();
            //await LoadData();
            //await LoadDataDataset();
            //await LoadDataEntityF();
        }
        //boilerplate code
        private async Task LoadData()
        {
            using(SqlConnection con = new SqlConnection("Data Source=DESKTOP-3C9CO9F;" + "Initial Catalog=MovieDB;" + "User ID=user1;" + "Password=mypass1"))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Employee", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //dataGridView1.DataSource = dt;
            }
            
        }
        //slow af
        private async Task LoadDataEntityF()
        {
            await moviedb.Employees.LoadAsync();
            employeeBindingSource.DataSource = moviedb.Employees.Local;
        }
        //long af
        private async Task LoadDataDataset()
        {
            EmployeeTableAdapter EmployeeAdapter= new EmployeeTableAdapter();
            MovieDBDataSet.EmployeeDataTable EmployeeTable = new MovieDBDataSet.EmployeeDataTable();
            EmployeeAdapter.Fill(EmployeeTable);
            //dataGridView1.DataSource = EmployeeTable;
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDBDataSet);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.employeeDataGridView.Sort(employeeDataGridView.Columns[comboBox1.SelectedIndex], ListSortDirection.Ascending);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if(checkBox.Checked == false)
            {
                this.employeeDataGridView.Columns[checkBox.Text].Visible = false;
                return;
            }
            this.employeeDataGridView.Columns[checkBox.Text].Visible = true;
        }
    }
}
