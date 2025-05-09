using E_CommercePanel.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_CommercePanel
{
    public partial class FrmCustomerPanel : Form
    {
        private int _customerID;
        public FrmCustomerPanel(int customerId)
        {
            InitializeComponent();
            _customerID = customerId;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditOwnInfo fr = new FrmEditOwnInfo(_customerID);
            fr.Show();
            this.Hide();
        }

        private void BtnOrderHistory_Click(object sender, EventArgs e)
        {
            FrmOrderHistory fr = new FrmOrderHistory(_customerID);
            fr.Show();
            this.Hide();
        }
    }
}
