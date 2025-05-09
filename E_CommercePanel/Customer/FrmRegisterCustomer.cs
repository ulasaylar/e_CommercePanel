using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_CommercePanel
{
    public partial class FrmRegisterCustomer : Form
    {
        public FrmRegisterCustomer()
        {
            InitializeComponent();
        }
        sqlConnection cnc = new sqlConnection();
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmCustomerLogin fr = new FrmCustomerLogin();
            fr.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("EXEC sp_RegisterCustomer @firstname = @p1,@lastname = @p2,@email = @p3,@phone = @p4,@username = @p5,@password = @p6", cnc.connection());
            com.Parameters.AddWithValue("@p1", txtFirstName.Text);
            com.Parameters.AddWithValue("@p2", txtLastName.Text);
            com.Parameters.AddWithValue("@p3", txtEmail.Text);
            com.Parameters.AddWithValue("@p4", txtPhone.Text);
            com.Parameters.AddWithValue("@p5", txtUsername.Text);
            com.Parameters.AddWithValue("@p6", txtPass.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("Registration Successful !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cnc.connection().Close();
        }
    }
}
