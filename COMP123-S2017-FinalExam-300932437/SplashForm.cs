using System;
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
        // public properties
        public PickHighestCardForm CardForm
        {
            get
            {
                return Program.CardForm;
            }
        }
        //constructor
        /// <summary>
        /// Main constructor for SplashForm
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for tick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            //shows the main game program
            this.CardForm.Show();
            //hides the splash screen
            this.Hide();
            // disables timer
            SplashTimer.Enabled = false;
            
        }
    }
}
