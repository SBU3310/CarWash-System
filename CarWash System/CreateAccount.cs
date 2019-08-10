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
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace CarWash_System
{
    public partial class CreateAccount : Form
    {
        Thread th;
        public CreateAccount()
        {
            InitializeComponent();
        }
        
        //private OleDbConnection dbConn;
        //private OleDbCommand dbCmd;
        //private string sConnection;
        //private string sql;

        private string connectionString = @"server=localhost;userid=root;password=Proline1;database=carwash";

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string idNum = txtID.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string carModel = cmbCarModel.Text;
            string amount = txtAmount.Text;
            string bankName = txtBankName.Text;
            string accNum = txtAccNum.Text;
            string debit = cmbDebit.Text;
            string credit = cmbCredit.Text;

            //try
            //{
            //    if (IsValid(name, surname, idNum, address, email, carModel, amount, bankName, accNum, debit, credit))
            //    {
            //        sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=carwash.accdb";
            //        dbConn = new OleDbConnection(sConnection);
            //        dbConn.Open();
            //        dbCmd = new OleDbCommand();
            //        sql = "insert into Register (Name,Surname,IDNumber,Address,EmailAddress,Carmodel,Amount,BankName,Account,Debit,Credit) values ('" + name + "','" + surname + "','" + idNum + "','" + address + "','" + email + "','" + carModel + "','" + amount + "','" + bankName + "','" + accNum + "','" + debit + "','" + credit + "' )";
            //        dbCmd.CommandText = sql;
            //        dbCmd.Connection = dbConn;
            //        dbCmd.ExecuteNonQuery();
            //        dbConn.Close();
            //        MessageBox.Show("User Account has been created", "User Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            //    }
            //    else
            //        MessageBox.Show("Please check your details", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("Please check your details", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //catch (ArgumentException)
            //{
            //    MessageBox.Show("Please check your details", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //}

            if (IsValid(name, surname, idNum, address, email, carModel, amount, bankName, accNum, debit, credit))
            {
                AddAccount(name, surname, idNum, address, email, carModel, amount, bankName, accNum, debit, credit);
            }
        }

        private void AddAccount(string name, string surname, string idNum, string address, string email, string carModel, string amount, string bankName, string accNum, string debit, string credit)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "INSERT INTO register(name, surname, idNumber, address, email, carModel, amount, bankName, accountNum, debit, credit) VALUES(@name, @surname, @idNum, @address, @email, @carModel, @amount, @bankName, @accNum, @debit, @credit)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@idNum", idNum);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@carModel", carModel);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@bankName", bankName);
                cmd.Parameters.AddWithValue("@accNum", accNum);
                cmd.Parameters.AddWithValue("@debit", debit);
                cmd.Parameters.AddWithValue("@credit", credit);
                cmd.ExecuteNonQuery();

                MessageBox.Show("User Account has been created", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private Boolean IsValid(string name, string surname, string idNum, string address, string email, string carModel, string amount, string bankName, string accNum, string debit, string credit)
        {
            try
            {
                name = name.Trim();
                surname = surname.Trim();
                idNum = idNum.Trim();
                address = address.Trim();
                email = email.Trim();
                carModel = carModel.Trim();
                amount = amount.Trim();
                bankName = bankName.Trim();
                accNum = accNum.Trim();
                debit = debit.Trim();
                credit = credit.Trim();

                bool emptyName = name != "" ? true : false;
                bool emptySurname = surname != "" ? true : false;
                bool emptyId = idNum != "" ? true : false;
                bool emptyAddress = address != "" ? true : false;
                bool emptyEmail = email != "" ? true : false;
                bool emptyCarModel = carModel != "" ? true : false;
                bool emptyAmount = amount != "" ? true : false;
                bool emptyBankName = bankName != "" ? true : false;
                bool emptyAccNum = accNum != "" ? true : false;
                bool emptyDebit = debit != "" ? true : false;
                bool emptyCredit = credit != "" ? true : false;

                bool validEmpty = emptyName && emptySurname && emptyId && emptyAddress && emptyEmail && emptyCarModel && emptyAmount && emptyBankName && emptyAccNum && emptyDebit && emptyCredit ? true : false;
                bool validId = idNum.Length != 14 ? true : false;
                MailAddress validEmail = new MailAddress(email);

                bool valid = validEmpty && validId ? true : false;
                return valid;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please check your details", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please check your details", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return false;
        }

        private void OpenCustForm(object obj)
        {
            if (!Customer.Instance.PnlContainer.Controls.ContainsKey("UCUnregistered"))
            {
                UCUnregistered uc = new UCUnregistered();
                uc.Dock = DockStyle.Fill;
                Customer.Instance.PnlContainer.Controls.Add(uc);
            }
            Customer.Instance.PnlContainer.Controls["UCUnregistered"].BringToFront();
            Application.Run(new Customer());
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenCustForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
