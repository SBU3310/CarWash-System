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

        private void button4_Click(object sender, EventArgs e)
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
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = "insert into Appointments (AppointmentNumber,Date,Time,ClientName) values ('" + appointNumber + "','" + date + "','" + time + "','" + name + "')";
                dbCmd.Connection = dbConn;
                dbCmd.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("User Account has been created ", "User Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("The client logged in has R500.00 \n in their account");
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBox1.Text);
            MessageBox.Show("Total Amount Deposited " + amount);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double creAmount = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("The client's credit has been increased by " + creAmount);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm1000);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm1000(object obj)
        {
            Application.Run(new Customer());
        }

        

        Double interior, exterior, both;
        Double amount = 0.0; 

        public double CalculateAmount()
        {
            if (checkBox1.Checked)
            {
                engineTurn = 50.00;
                amount = 50.00;
            }

            if (checkBox2.Checked)
            {
                oil = 20.00;
                amount = amount + 20.00;

            }

            if (checkBox3.Checked)
            {
                oilFilter = 30.00;
                amount = amount + 30.00;

            }

            if (checkBox4.Checked)
            {
                grease = 50.00;
                amount = amount + 50.00;
            }

            if (checkBox5.Checked)
            {
                airFilter = 100.00;
                amount = amount + 100.00;
            }

            if (checkBox6.Checked)
            {
                interior = 100.00;
                amount = amount + 100;
            }

            if (checkBox7.Checked)
            {
                exterior = 150.00;
                amount = amount + 150.00;
            }

            if (checkBox8.Checked)
            {
                both = 300.00;
                amount = amount + 300.00;
            }

            return amount; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("The total amount the client owes is " + "R" + CalculateAmount()); 
        }
    }
}
