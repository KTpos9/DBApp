using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApps.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }
        bool resizingTlp;

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            if (resizingTlp)
            {
                return;
            }
            resizingTlp = true;
            if (tableLayoutPanel1.Height <= panel1.ClientSize.Height)
            {
                tableLayoutPanel1.Width = panel1.ClientSize.Width;
            }
            else
            {
                tableLayoutPanel1.Width = panel1.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;
                resizingTlp = false;
            }
        }
    }
}
