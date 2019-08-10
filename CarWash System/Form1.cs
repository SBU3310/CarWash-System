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

        private void OpenCustForm(object obj)
        {
            Application.Run(new Customer());
        }

        private void OpenManForm(object obj)
        {
            Application.Run(new Management());
        }

        private void OpenRecepForm(object obj)
        {
            Application.Run(new Receptionist());
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenCustForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            Customer myCust = new Customer();
            myCust.Show(); 
        }

        private void BtnManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenManForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            Management myMan = new Management();
            myMan.Show();
        }

        private void BtnReceptionist_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenRecepForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            Receptionist myRec = new Receptionist();
            myRec.Show(); 
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
