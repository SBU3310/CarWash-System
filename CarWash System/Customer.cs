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
    public partial class Customer : Form
    {
        Thread th;
        public Customer()
        {
            InitializeComponent();
        }
        String username1 = "123456";
        String password1 = "123456"; 

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void openWelcomeForm(object obj)
        {
            Application.Run(new WelcomeForm());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openWelcomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openRegisteredForm(object obj)
        {
            Application.Run(new RegisteredClients());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
           
            if(username1 == username && password1 == password)
            {
                MessageBox.Show("Correct Credentials", "Validation");

                this.Close();
                th = new Thread(openRegisteredForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

            }
            else
            {
                MessageBox.Show("Incorrect Credentilas", "Validation"); 
            }
        }

        private void openCreateForm(object obj)
        {
            Application.Run(new CreateAccount());
        }

        Double engineTurn, oil, oilFilter, grease, aitFilter;
        Double interior, exterior, both;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openCreateForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openWelcomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public double CalculateAmount()
        {
            Double amount = 0.0;

            if (chkTurning.Checked)
            {
                engineTurn = 50.00;
                amount = 50.00;
            }

            if (chkOil.Checked)
            {
                oil = 20.00;
                amount = amount + 20.00;

            }

            if (chkFilter.Checked)
            {
                oilFilter = 30.00;
                amount = amount + 30.00;

            }

            if (chkGrease.Checked)
            {
                grease = 50.00;
                amount = amount + 50.00;
            }

            if (chkAir.Checked)
            {
                aitFilter = 100.00;
                amount = amount + 100.00;
            }

            if (radInterior.Checked)
            {
                interior = 100.00;
                amount = amount + 100;
            }

            if (radExterior.Checked)
            {
                exterior = 150.00;
                amount = amount + 150.00;
            }

            if (radBoth.Checked)
            {
                both = 300.00;
                amount = amount + 300.00;
            }

            return amount;
        }

        String name, surname, carModel, regNumber; 

        private void btnEnter_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            surname = txtSurname.Text;
            carModel = txtModel.Text;
            regNumber = txtRegistration.Text; 

            MessageBox.Show("The client " + name + " " + surname + " with car model " + carModel + " and regestration number " + regNumber + " the total amount he/she is expected to pay is "  + "R" + CalculateAmount(), "Total Amount", MessageBoxButtons.OK, MessageBoxIcon.None); 
        }
    }
}
