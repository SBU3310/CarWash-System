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
    public partial class RegisteredClients : Form
    {
        static RegisteredClients _obj;

        public static RegisteredClients Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new RegisteredClients();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return pnlContainer; }
            set { pnlContainer = value; }
        }

        public RegisteredClients()
        {
            InitializeComponent();
        }

        private void RegisteredClients_Load(object sender, EventArgs e)
        {
            _obj = this;

            UCRegHome uc = new UCRegHome();
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uc);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Top = btnHome.Top;
            
            if (!RegisteredClients.Instance.PnlContainer.Controls.ContainsKey("UCRegHome"))
            {
                UCRegHome uc = new UCRegHome();
                uc.Dock = DockStyle.Fill;
                RegisteredClients.Instance.PnlContainer.Controls.Add(uc);
            }
            RegisteredClients.Instance.PnlContainer.Controls["UCRegHome"].BringToFront();
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            pnlNav.Top = btnTrans.Top;

            if (!RegisteredClients.Instance.PnlContainer.Controls.ContainsKey("UCTransaction"))
            {
                UCTransaction uc = new UCTransaction();
                uc.Dock = DockStyle.Fill;
                RegisteredClients.Instance.PnlContainer.Controls.Add(uc);
            }
            RegisteredClients.Instance.PnlContainer.Controls["UCTransaction"].BringToFront();
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            pnlNav.Top = btnApp.Top;

            if (!RegisteredClients.Instance.PnlContainer.Controls.ContainsKey("UCAppointment"))
            {
                UCAppointment uc = new UCAppointment();
                uc.Dock = DockStyle.Fill;
                RegisteredClients.Instance.PnlContainer.Controls.Add(uc);
            }
            RegisteredClients.Instance.PnlContainer.Controls["UCAppointment"].BringToFront();
        }
    }
}
