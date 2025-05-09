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

namespace E_CommercePanel
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }
        sqlConnection cnc = new sqlConnection();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Admins where AdminUsername=@p1 and AdminPassword=@p2", cnc.connection());
            cmd.Parameters.AddWithValue("@p1",txtUsername.Text);
            cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmAdminPanel fr = new FrmAdminPanel();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cnc.connection().Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmLogin fr = new FrmLogin();
            fr.Show();
            this.Hide();
        }
    }
}
