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
using System.Data.OleDb; 

namespace CarWash_System
{
    public partial class RegisteredClients : Form
    {
        Thread th;
        public RegisteredClients()
        {
            InitializeComponent();
        }

        Double engineTurn, oil, oilFilter, grease, airFilter;
       // String appointNumber, time, date, name;

        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private OleDbCommand dcCmd;
        private string sConnection;
        private string sql;

        private void BtnAppEnter_Click(object sender, EventArgs e)
        {
          string appointNumber = txtAppNum.Text;
          string date = txtDate.Text;
          string time = txtTime.Text;
          string name = txtName.Text;

            try
            {
                sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=carwash.accdb";
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();
                dbCmd = new OleDbCommand
                {
                    CommandText = "insert into Appointments (AppointmentNumber,Date,Time,ClientName) values ('" + appointNumber + "','" + date + "','" + time + "','" + name + "')",
                    Connection = dbConn
                };
                dbCmd.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("User Account has been created ", "User Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }


        private void BtnCheck_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("The client logged in has R500.00 \n in their account");
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtAmount.Text);
            MessageBox.Show("Total Amount Deposited " + amount);
           
        }

        private void BtnCredDone_Click(object sender, EventArgs e)
        {
            double creAmount = Convert.ToDouble(txtCredAmount.Text);
            MessageBox.Show("The client's credit has been increased by " + creAmount);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenCustomerForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenCustomerForm(object obj)
        {
            Application.Run(new Customer());
        }

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

        private void BtnEnter_Click(object sender, EventArgs e)
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
