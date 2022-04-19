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
            //create a new panel use for display accent color when navigation button(label) is selected
            //delete these 3 lines if use the "Dispose solution code"
            leftBorderAccentColor = new Panel();
            leftBorderAccentColor.Size = new Size(4, 15);
            panelNavigation.Controls.Add(leftBorderAccentColor);
        }

        private Label lblCurrent;
        private Panel leftBorderAccentColor;
        private Color clickedColor = Color.FromArgb(234, 234, 234);
        private Color nonClickColor = Color.FromArgb(243, 243, 243);
        private Color accentColor = Color.FromArgb(0,120,212);
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
            if(lblCurrent != null)
            {
                lblCurrent.BackColor = nonClickColor;
                leftBorderAccentColor.BackColor = nonClickColor;
                /* "Dispose solution code" (remove the "leftBorderAccentColor.BackColor = nonClickColor;" line first)
                 * Dispose the panel when new navigation button(label) is selected
                    leftBorderAccentColor.Dispose();
                */
            }
        }

        //change all the label's BackColor to nonClickColor, then change the Clicked label to clickedColor and add leftBorderAccentColor
        private void ChangeColorOnEvent(object sender)
        {
            if(sender != null) //&& lblCurrent != (Label)sender)
            {
                ReverseLabelColor();
                lblCurrent = (Label)sender;
                lblCurrent.BackColor = clickedColor;

                /* "Dispose solution code" (put these code on top of leftBorderAccentColor.BackColor = accentColor;)
                 * create a panel by triggering the event then Dispose later when new Navigation button(label) is selected
                    leftBorderAccentColor = new Panel();
                    leftBorderAccentColor.Size = new Size(5, 25);
                    panelNavigation.Controls.Add(leftBorderAccentColor);
                */

                leftBorderAccentColor.BackColor = accentColor;
                leftBorderAccentColor.Location = new Point(13, lblCurrent.Location.Y+9);
                leftBorderAccentColor.Visible = true;
                leftBorderAccentColor.BringToFront();
            }
        }
    }
}
