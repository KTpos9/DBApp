using System;
using System.Drawing;
using System.Windows.Forms;


namespace DBApps
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            leftBorderAccentColor = new Panel();
            leftBorderAccentColor.Size = new Size(4, 15);
            panelNavigation.Controls.Add(leftBorderAccentColor);
            //testtt
        }

        private Label lblCurrent;
        private Panel leftBorderAccentColor;
        private Form currentActiveForm;

        private System.Drawing.Color clickedColor = System.Drawing.Color.FromArgb(234, 234, 234);
        private System.Drawing.Color nonClickColor = System.Drawing.Color.FromArgb(243, 243, 243);
        private System.Drawing.Color accentColor = System.Drawing.Color.FromArgb(0,120,212);
        #region LabelEvents
        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            if (label.BackColor == clickedColor)
            {
                return;
            }
            label.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
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
            if((Label)sender == lblCurrent)
            {
                return;
            }
            ChangeColorOnEvent(sender);
            if((Label)sender == labelSetting)
            {
                OpenMenuForm(new Forms.FormSettings());
            }
            else if ((Label)sender == labelhome)
            {
                OpenMenuForm(new Forms.Home());
            }
            else if ((Label)sender == labelinformation)
            {
                OpenMenuForm(new Forms.information());
            }
            else if((Label)sender == labelEdit)
            {
                OpenMenuForm(new Forms.FormEdit());
            }
            else if((Label)sender == labelReport)
            {
                OpenMenuForm(new Forms.FormReport());
            }
        }

        //change all the label's BackColor to nonClickColor
        private void ReverseLabelColor()
        {
            if(lblCurrent != null)
            {
                lblCurrent.BackColor = nonClickColor;
                leftBorderAccentColor.BackColor = nonClickColor;
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

                leftBorderAccentColor.BackColor = accentColor;
                leftBorderAccentColor.Location = new Point(18, lblCurrent.Location.Y+9);
                leftBorderAccentColor.Visible = true;
                leftBorderAccentColor.BringToFront();
            }
        }
        #endregion
        private void OpenMenuForm(Form menuForm)
        {
            if (currentActiveForm != null)
            {
                currentActiveForm.Dispose();
                GC.Collect();
            }
            currentActiveForm = menuForm;
            menuForm.TopLevel = false;
            menuForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(menuForm);
            panel2.Tag = menuForm;
            menuForm.BringToFront();
            menuForm.Show();
        }
    }
}