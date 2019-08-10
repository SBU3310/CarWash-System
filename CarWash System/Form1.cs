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
    public partial class WelcomeForm : Form
    {
        Thread th;
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void openCustForm(object obj)
        {
            Application.Run(new Customer());
        }

        private void openManForm(object obj)
        {
            Application.Run(new Management());
        }

        private void openRecepForm(object obj)
        {
            Application.Run(new Receptionist());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openCustForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            Customer myCust = new Customer();
            myCust.Show(); 
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openManForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            Management myMan = new Management();
            myMan.Show();
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openRecepForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            Receptionist myRec = new Receptionist();
            myRec.Show(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
