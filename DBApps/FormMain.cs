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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Label lblCurrent;
        private Color clickedColor = Color.FromArgb(234, 234, 234);
        private Color nonClickColor = Color.FromArgb(243, 243, 243);
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.FromArgb(243, 243, 243);//240,243,249
            int borderMargin = 20;
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, color, borderMargin - 10, ButtonBorderStyle.Solid, color, borderMargin, ButtonBorderStyle.Solid, color, borderMargin, ButtonBorderStyle.Solid, color, borderMargin, ButtonBorderStyle.Solid);
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.BackColor == clickedColor)
            {
                return;
            }
            label.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.BackColor == clickedColor)
            {
                return;
            }
            label.BackColor = nonClickColor;
        }

        private void label_Click(object sender, EventArgs e)
        {
            ChangeColorOnEvent(sender);
        }

        //change all the label's BackColor to nonClickColor
        private void ReverseLabelColor()
        {
            foreach(Control lblAsButtons in panelNavigation.Controls)
            {
                if(lblAsButtons is Label)
                {
                    lblAsButtons.BackColor = nonClickColor;
                }
            }
        }

        //change all the label's BackColor to nonClickColor, then change the Clicked label to clickedColor 
        private void ChangeColorOnEvent(object sender)
        {
            if(sender != null && lblCurrent != (Label)sender)
            {
                ReverseLabelColor();
                lblCurrent = (Label)sender;
                lblCurrent.BackColor = clickedColor;
            }
        }
    }
}
