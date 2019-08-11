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
    public partial class UCRegHome : UserControl
    {
        Thread th;
        public UCRegHome()
        {
            InitializeComponent();
        }

        private void OpenCustomerForm(object obj)
        {
            Application.Run(new Customer());
        }

        Double engineTurn, oil, oilFilter, grease, airFilter;
        Double interior, exterior, both;
        public double CalculateAmount()
        {
            Double amount = 0.0;

            if (chkTurning.Checked)
            {
                engineTurn = 50.00;
                amount = 50.00;
            }

            if (chkEngOil.Checked)
            {
                oil = 20.00;
                amount = amount + 20.00;
            }

            if (chkOilFil.Checked)
            {
                oilFilter = 30.00;
                amount = amount + 30.00;

            }

            if (chkGrease.Checked)
            {
                grease = 50.00;
                amount = amount + 50.00;
            }

            if (chkAirFil.Checked)
            {
                airFilter = 100.00;
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String message = "";
            message = "Maintenance\n";
            message += "===========================";
            message += chkTurning.Checked ? "EngineTurning\n" : "";
            message += chkEngOil.Checked ? "Engine Oil\n" : "";
            message += chkOilFil.Checked ? "Oil Filter\n" : "";
            message += chkGrease.Checked ? "Grease & Lubricants\n" : "";
            message += chkAirFil.Checked ? "Air Filter\n" : "";

            message += "\n";
            message += "Car Wash\n";
            message += "===========================";
            message += radInterior.Checked ? "Interior" : radExterior.Checked ? "Exterior" : radBoth.Checked ? "Both" : "";
            message += "\n";
            message += "The total amount the client owes is " + "R" + CalculateAmount();

            redOutput.Text = message;
        }
    }
}
