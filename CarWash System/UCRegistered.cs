using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CarWash_System
{
    public partial class UCRegistered : UserControl
    {
        Thread th;
        public UCRegistered()
        {
            InitializeComponent();
        }

        private void OpenWelcomeForm(object obj)
        {
            Application.Run(new WelcomeForm());
        }

        private void OpenRegisteredForm(object obj)
        {
            Application.Run(new RegisteredClients());
        }

        String username1 = "123456";
        String password1 = "123456";
        private void btnNext_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            if ((username1 == username && password1 == password) && (IsValid(username, password)))
            {
                MessageBox.Show("Correct Credentials", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Customer.Instance.Close();
                th = new Thread(OpenRegisteredForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

            }
            else
            {
                MessageBox.Show("Incorrect Credentilas", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Customer.Instance.Close();
            th = new Thread(OpenWelcomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private bool IsValid(string username, string password)
        {
            username = username.Trim();
            password = password.Trim();

            bool validUsename = username != "" ? true : false;
            bool validPassword = password != "" ? true : false;

            bool valid = validUsename && validPassword ? true : false;
            return valid;
        }
    }
}
