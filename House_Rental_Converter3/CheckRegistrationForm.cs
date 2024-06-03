﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace House_Rental_Converter3
{
    public partial class CheckRegistrationForm : Form
    {
        
        Converter converter = new Converter();
        public CheckRegistrationForm()
        {
            InitializeComponent();
        }

        private void CheckRegistrationForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey mainKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            RegistryKey appKey = mainKey.OpenSubKey("House_Rental_Converter3", true);
            if (appKey != null && appKey.GetSubKeyNames() != null)
            {
                string startDateString = (string)appKey.GetValue("Start_Trial");
                if (DateTime.TryParse(startDateString, out DateTime start_date))
                {
                    //  remaining time😍,I like it 
                    TimeSpan remainingTime = start_date.AddDays(30) - DateTime.Now;
                    string remainingTimeStr = $"{remainingTime.Days} days, {remainingTime.Hours} hours, {remainingTime.Minutes} minutes, {remainingTime.Seconds} seconds";

                    if (DateTime.Now > start_date.AddDays(30)) // Check if 30 days have passed
                    {
                        MessageBox.Show("Your trial period has expired. Please purchase a registration key to continue using the application.", "Trial Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Open the default web browser to your website for purchasing a key
                        System.Diagnostics.Process.Start("https://homeiphone.ir");
                    }
                    else
                    {
                        MessageBox.Show($"Your trial period will expire in {remainingTimeStr}.", "Trial Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        converter.FormClosed += (s, args) => this.Close();
                        this.Hide();
                        converter.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid start date format. Please reinstall the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Key does not exist, create it
                appKey = mainKey.CreateSubKey("House_Rental_Converter3");

                appKey.SetValue("Start_Trial", DateTime.Now);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.homeiphone.ir");
        }


  

    

    }
}
