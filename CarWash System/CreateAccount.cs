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
    public partial class CreateAccount : Form
    {
        Thread th;
        public CreateAccount()
        {
            InitializeComponent();
        }
        
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private OleDbCommand dcCmd;
        private string sConnection;
        private string sql;      

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string idnumber = txtID.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string carmodel = cmbCarModel.Text;
            string amount = txtAccNum.Text;
            string bankname = txtBankName.Text;
            string accountNo = txtAccNum.Text;
            string Debit = cmbDebit.Text;
            string Credit = cmbCredit.Text;

            try
            {
                sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=carwash.accdb";
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = "insert into Register (Name,Surname,IDNumber,Address,EmailAddress,Carmodel,Amount,BankName,AccountNumber,Debit,Credit) values ('" + Name + "','" + surname + "','" + idnumber + "','" + address + "','" + email + "','" + carmodel + "','" + amount + "','" + bankname + "','" + accountNo + "','" + Debit + "','" + Credit + "' )";
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

        private void openCustForm(object obj)
        {
            Application.Run(new Customer());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openCustForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
