using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWash_System
{
    public partial class UCTransaction : UserControl
    {
        public UCTransaction()
        {
            InitializeComponent();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            double creAmount = Convert.ToDouble(txtAmount.Text);
            MessageBox.Show("The client's credit has been increased by " + creAmount);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtAmount.Text);
            MessageBox.Show("Total Amount Deposited " + amount);
        }

        private void UCTransaction_Load(object sender, EventArgs e)
        {

        }
    }
}
