namespace House_Rental_Converter3
{
    partial class CheckRegistrationForm
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
            this.check_btn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // check_btn
            // 
            this.check_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.check_btn.Location = new System.Drawing.Point(16, 184);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(450, 32);
            this.check_btn.TabIndex = 0;
            this.check_btn.Text = "Register Check";
            this.check_btn.UseVisualStyleBackColor = false;
            this.check_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(13, 455);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 24);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "homeiphone.ir";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CheckRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(491, 486);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.check_btn);
            this.MaximumSize = new System.Drawing.Size(509, 533);
            this.MinimumSize = new System.Drawing.Size(509, 47);
            this.Name = "CheckRegistrationForm";
            this.Text = "Check Registration Form";
            this.Load += new System.EventHandler(this.CheckRegistrationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}