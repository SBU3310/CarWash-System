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
    public partial class UCUnregistered : UserControl
    {
        Thread th;
        public UCUnregistered()
        {
            InitializeComponent();
        }

        private void OpenCreateForm(object obj)
        {
            Application.Run(new CreateAccount());
        }

        private void OpenWelcomeForm(object obj)
        {
            Application.Run(new WelcomeForm());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Customer.Instance.Close();
            th = new Thread(OpenCreateForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        String name, surname, carModel, regNumber;

        private void btnBack_Click(object sender, EventArgs e)
        {
            Customer.Instance.Close();
            th = new Thread(OpenWelcomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            surname = txtSurname.Text;
            carModel = txtModel.Text;
            regNumber = txtRegistration.Text;

            MessageBox.Show("The client " + name + " " + surname + " with car model " + carModel + " and regestration number " + regNumber + " the total amount he/she is expected to pay is " + "R" + CalculateAmount(), "Total Amount", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public double CalculateAmount()
        {
            Double engineTurn, oil, oilFilter, grease, aitFilter;
            Double interior, exterior, both;

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
    }
}
