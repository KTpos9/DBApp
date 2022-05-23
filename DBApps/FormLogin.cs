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

namespace DBApps
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (checkBoxDebug.Checked)
            {
                this.Hide();
                var fm = new FormMain();
                fm.Closed += (s, args) => this.Close();
                fm.Show();
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=sqlserver.3bbddns.com, 22190;" + "Initial Catalog=MovieDB;" + "User ID=user1;Password=mypass1");
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"select EmpID, EmpPassword, EmpPositionID, EmpFname, EmpSname from Employee where EmpID ='{textBox1.Text}' and EmpPassword = '{textBox2.Text}'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    this.Hide();
                    var fm = new FormMain();
                    fm.Closed += (s, args) => this.Close();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!");
                }
                conn.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Exception catched! "+ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
