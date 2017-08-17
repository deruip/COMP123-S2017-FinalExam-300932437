﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Aron Ly
 * Date: August 17, 2017
 * StudentID: 300932437
 * Description: Splash Screen that shows before program starts
 * Version: 0.2 - enabled the splash form
 */
namespace COMP123_S2017_FinalExam_300932437
{
    public partial class SplashForm : Form
    {
        public PickHighestCardForm CardForm
        {
            get
            {
                return Program.CardForm;
            }
        }
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.CardForm.Show();
            this.Hide();
            timer1.Enabled = false;
            
        }
    }
}
