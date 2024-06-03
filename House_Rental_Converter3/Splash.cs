using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace House_Rental_Converter3
{
    public partial class Splash : Form
    {
        ProgressBar progressBar;
        CheckRegistrationForm checkRegisterWindow = new CheckRegistrationForm();
        Timer timer;
        int progressValue = 0;
        public Splash()
        {
            InitializeComponent();
            progressBar = new ProgressBar();
            progressBar.Location = new Point(100, 420);
            progressBar.Size = new Size(300, 16);
            progressBar.ForeColor = Color.Black;
            progressBar.BackColor = Color.Gray;
            this.Controls.Add(progressBar);
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressValue += 5;
            progressBar.Value = progressValue;
            if (progressBar.Value >= 100)
            {
                timer.Stop();
                checkRegisterWindow.FormClosed += (s, args) => this.Close();
                this.Hide();
                checkRegisterWindow.Show();
            }

        }
    }
}
