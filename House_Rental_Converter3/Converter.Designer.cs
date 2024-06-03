namespace House_Rental_Converter3
{
    partial class Converter
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهبرنامهنویسانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rent_num = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prepeyment_number = new System.Windows.Forms.NumericUpDown();
            this.prepayment_lbl = new System.Windows.Forms.Label();
            this.rent_lbl = new System.Windows.Forms.Label();
            this.rent_to_prepeyment_btn = new System.Windows.Forms.Button();
            this.prepeyment_to_rent_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rent_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepeyment_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 524);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 16);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "another app";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 28);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.دربارهماToolStripMenuItem,
            this.دربارهبرنامهنویسانToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.fileToolStripMenuItem.Text = "Application";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.exitToolStripMenuItem.Text = "سایر برنامه‌های رایگان";
            // 
            // دربارهماToolStripMenuItem
            // 
            this.دربارهماToolStripMenuItem.Name = "دربارهماToolStripMenuItem";
            this.دربارهماToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.دربارهماToolStripMenuItem.Text = "درباره ما";
            // 
            // دربارهبرنامهنویسانToolStripMenuItem
            // 
            this.دربارهبرنامهنویسانToolStripMenuItem.Name = "دربارهبرنامهنویسانToolStripMenuItem";
            this.دربارهبرنامهنویسانToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.دربارهبرنامهنویسانToolStripMenuItem.Text = "درباره برنامه نویسان";
            // 
            // rent_num
            // 
            this.rent_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rent_num.Location = new System.Drawing.Point(12, 58);
            this.rent_num.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.rent_num.Name = "rent_num";
            this.rent_num.Size = new System.Drawing.Size(420, 49);
            this.rent_num.TabIndex = 33;
            this.rent_num.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "مبلغ اجاره را به تومان وارد کنید";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "مبلغ رهن را به تومان وارد کنید";
            // 
            // prepeyment_number
            // 
            this.prepeyment_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepeyment_number.Location = new System.Drawing.Point(24, 302);
            this.prepeyment_number.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.prepeyment_number.Name = "prepeyment_number";
            this.prepeyment_number.Size = new System.Drawing.Size(408, 49);
            this.prepeyment_number.TabIndex = 36;
            this.prepeyment_number.ThousandsSeparator = true;
            // 
            // prepayment_lbl
            // 
            this.prepayment_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prepayment_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepayment_lbl.Location = new System.Drawing.Point(679, 66);
            this.prepayment_lbl.Name = "prepayment_lbl";
            this.prepayment_lbl.Size = new System.Drawing.Size(159, 40);
            this.prepayment_lbl.TabIndex = 37;
            this.prepayment_lbl.Text = "مبلغ رهن ";
            this.prepayment_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rent_lbl
            // 
            this.rent_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rent_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rent_lbl.Location = new System.Drawing.Point(680, 301);
            this.rent_lbl.Name = "rent_lbl";
            this.rent_lbl.Size = new System.Drawing.Size(165, 40);
            this.rent_lbl.TabIndex = 38;
            this.rent_lbl.Text = "مبلغ اجاره";
            this.rent_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rent_to_prepeyment_btn
            // 
            this.rent_to_prepeyment_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rent_to_prepeyment_btn.Location = new System.Drawing.Point(462, 66);
            this.rent_to_prepeyment_btn.Name = "rent_to_prepeyment_btn";
            this.rent_to_prepeyment_btn.Size = new System.Drawing.Size(168, 33);
            this.rent_to_prepeyment_btn.TabIndex = 39;
            this.rent_to_prepeyment_btn.Text = "تبدیل اجاره به رهن";
            this.rent_to_prepeyment_btn.UseVisualStyleBackColor = false;
            this.rent_to_prepeyment_btn.Click += new System.EventHandler(this.rent_to_prepeyment_btn_Click);
            // 
            // prepeyment_to_rent_btn
            // 
            this.prepeyment_to_rent_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.prepeyment_to_rent_btn.Location = new System.Drawing.Point(462, 303);
            this.prepeyment_to_rent_btn.Name = "prepeyment_to_rent_btn";
            this.prepeyment_to_rent_btn.Size = new System.Drawing.Size(168, 39);
            this.prepeyment_to_rent_btn.TabIndex = 40;
            this.prepeyment_to_rent_btn.Text = "تبدیل رهن به اجاره";
            this.prepeyment_to_rent_btn.UseVisualStyleBackColor = false;
            this.prepeyment_to_rent_btn.Click += new System.EventHandler(this.prepeyment_to_rent_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "راه‌اندازی مجدد",
            "جمع اجاره",
            "جمع رهن"});
            this.comboBox1.Location = new System.Drawing.Point(24, 439);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 39);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // total_txt
            // 
            this.total_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txt.Location = new System.Drawing.Point(299, 439);
            this.total_txt.Name = "total_txt";
            this.total_txt.Size = new System.Drawing.Size(237, 38);
            this.total_txt.TabIndex = 45;
            this.total_txt.Text = "جمع ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::House_Rental_Converter3.Properties.Resources.arrowDown_left;
            this.pictureBox2.Location = new System.Drawing.Point(176, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.pictureBox2.Size = new System.Drawing.Size(635, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::House_Rental_Converter3.Properties.Resources.arrowDown;
            this.pictureBox1.Location = new System.Drawing.Point(176, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(868, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.prepeyment_to_rent_btn);
            this.Controls.Add(this.rent_to_prepeyment_btn);
            this.Controls.Add(this.rent_lbl);
            this.Controls.Add(this.prepayment_lbl);
            this.Controls.Add(this.prepeyment_number);
            this.Controls.Add(this.rent_num);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.linkLabel1);
            this.MaximumSize = new System.Drawing.Size(886, 605);
            this.MinimumSize = new System.Drawing.Size(886, 605);
            this.Name = "Converter";
            this.Text = "مبدل رهن و اجاره";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rent_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepeyment_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown rent_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown prepeyment_number;
        private System.Windows.Forms.Label prepayment_lbl;
        private System.Windows.Forms.Label rent_lbl;
        private System.Windows.Forms.Button rent_to_prepeyment_btn;
        private System.Windows.Forms.Button prepeyment_to_rent_btn;
        private System.Windows.Forms.ToolStripMenuItem دربارهماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهبرنامهنویسانToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox total_txt;
    }
}