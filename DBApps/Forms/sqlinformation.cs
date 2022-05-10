using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBApps.Forms
{
    public partial class sqlinformation : Form
    {
        SqlConnection  appdb ;
        public sqlinformation()
        {
            InitializeComponent();
        }

        private void sqlinformation_Load(object sender, EventArgs e)
        {
           // var appdb = new SqlConnection ("Data Source=LEGIONY450;" + "Initial Catalog=DataApp;" + "User ID=user1;" + "Password=mypass1;");
           // appdb.Open ();

          //  var command = new SqlCommand("Select * from Employee", appdb);
          //  var EmployeeAdapter = new SqlDataAdapter();
           // EmployeeAdapter.SelectCommand = command;
           // var EmployeeTable = new DataTable();
           // EmployeeAdapter.Fill(EmployeeTable);

           // textBox1.DataBindings.Add("Text", EmployeeTable, "EmpSalary");

            
           //+++ employeeManager = (CurrencyManager)BindingContext[employeeTable];

          //  appdb.Close();
            //++++ Dispose of the connection object   
          //  appdb.Dispose();
          //  command.Dispose();
          //  EmployeeAdapter.Dispose();
            
        }
    }
}
