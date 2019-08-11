using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWash_System
{
    public partial class Customer : Form
    {
        static Customer _obj;

        public static Customer Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Customer();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return pnlContainer; }
            set { pnlContainer = value; }
        }

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            _obj = this;

            UCRegistered uc = new UCRegistered();
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uc);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlNav.Left = btnNew.Left;

            if (!Customer.Instance.PnlContainer.Controls.ContainsKey("UCUnregistered"))
            {
                UCUnregistered uc = new UCUnregistered();
                uc.Dock = DockStyle.Fill;
                Customer.Instance.PnlContainer.Controls.Add(uc);
            }
            Customer.Instance.PnlContainer.Controls["UCUnregistered"].BringToFront();
        }

        private void btnRegistered_Click(object sender, EventArgs e)
        {
            pnlNav.Left = btnRegistered.Left;

            if (!Customer.Instance.PnlContainer.Controls.ContainsKey("UCRegistered"))
            {
                UCRegistered uc = new UCRegistered();
                uc.Dock = DockStyle.Fill;
                Customer.Instance.PnlContainer.Controls.Add(uc);
            }
            Customer.Instance.PnlContainer.Controls["UCRegistered"].BringToFront();
        }
    }
}
