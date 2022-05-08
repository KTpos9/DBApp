namespace DBApps.Forms
{
    partial class pay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonpay = new System.Windows.Forms.Button();
            this.labeltext1 = new System.Windows.Forms.Label();
            this.textpay = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonpay
            // 
            this.buttonpay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonpay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonpay.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpay.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonpay.Location = new System.Drawing.Point(16, 126);
            this.buttonpay.Name = "buttonpay";
            this.buttonpay.Size = new System.Drawing.Size(235, 52);
            this.buttonpay.TabIndex = 0;
            this.buttonpay.Text = "ชําระเงิน";
            this.buttonpay.UseVisualStyleBackColor = false;
            this.buttonpay.Click += new System.EventHandler(this.buttonpay_Click);
            // 
            // labeltext1
            // 
            this.labeltext1.AutoSize = true;
            this.labeltext1.BackColor = System.Drawing.Color.Transparent;
            this.labeltext1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltext1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labeltext1.Location = new System.Drawing.Point(60, 16);
            this.labeltext1.Name = "labeltext1";
            this.labeltext1.Size = new System.Drawing.Size(150, 50);
            this.labeltext1.TabIndex = 1;
            this.labeltext1.Text = "ยอดชำระ";
            this.labeltext1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textpay
            // 
            this.textpay.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textpay.Location = new System.Drawing.Point(16, 69);
            this.textpay.Multiline = true;
            this.textpay.Name = "textpay";
            this.textpay.ReadOnly = true;
            this.textpay.Size = new System.Drawing.Size(235, 51);
            this.textpay.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.labeltext1);
            this.groupBox1.Controls.Add(this.buttonpay);
            this.groupBox1.Controls.Add(this.textpay);
            this.groupBox1.Location = new System.Drawing.Point(532, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 199);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 551);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "pay";
            this.Text = "ui";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labeltext1;
        private System.Windows.Forms.TextBox textpay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonpay;
    }
}