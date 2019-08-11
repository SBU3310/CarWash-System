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
    public partial class Management : Form
    {
        Thread th;
        public Management()
        {
            InitializeComponent();
        }
        private void OpenWelcomeForm(object obj)
        {
            Application.Run(new WelcomeForm());
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenWelcomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void BtnViewClientAcc_Click(object sender, EventArgs e)
        {

        }

        private void BtnChkCash_Click(object sender, EventArgs e)
        {

        }

        private void Management_Load(object sender, EventArgs e)
        {

        }
    }
}
