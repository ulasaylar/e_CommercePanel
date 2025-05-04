using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using E_CommercePanel.Customer;

namespace E_CommercePanel
{
    public partial class FrmCustomerLogin : Form
    {
        sqlConnection cnc = new sqlConnection();
        public FrmCustomerLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_CustomersLogin where CustomerUsername=@p1 and CustomerPassword=@p2", cnc.connection());
            cmd.Parameters.AddWithValue("@p1", txtUsername.Text);
            cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int customerId = Convert.ToInt32(dr["CustomerId"]);
                FrmCustomerPanel fr = new FrmCustomerPanel(customerId);
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cnc.connection().Close();
        }
    }
}
