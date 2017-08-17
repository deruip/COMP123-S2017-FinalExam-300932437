using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Aron Ly
 * Date: August 17, 2017
 * StudentID: 300932437
 * Description: Program class
 * Version: 0.2 - 
 */

namespace COMP123_S2017_FinalExam_300932437
{
    public static class Program
    {
        // reference to forms
        public static PickHighestCardForm CardForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //instantiates new PickHighestCardForm
            CardForm = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
