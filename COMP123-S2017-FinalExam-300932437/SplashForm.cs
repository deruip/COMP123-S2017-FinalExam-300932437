using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            timer1.Stop();
            this.Hide();
            PickHighestCardForm CardForm = new PickHighestCardForm();
            CardForm.Show();
            
        }
    }
}
