using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CarWash_System
{
    public partial class Receptionist : Form
    {
        Thread th;
        public Receptionist()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void OpenWelcomeForm(object obj)
        {
            Application.Run(new WelcomeForm());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenWelcomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string transNum;
        }
    }
}
