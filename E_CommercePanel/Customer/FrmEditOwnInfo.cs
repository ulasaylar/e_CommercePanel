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

namespace E_CommercePanel.Customer
{
    public partial class FrmEditOwnInfo : Form
    {
        private int _customerID;
        sqlConnection cnc = new sqlConnection();
        public FrmEditOwnInfo(int customerId)
        {
            InitializeComponent();
            _customerID = customerId;
        }
        private void FrmEditOwnInfo_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Customers WHERE CustomerID = @p1", cnc.connection());
            cmd.Parameters.AddWithValue("@p1", _customerID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtId.Text = dr[0].ToString();
                txtFirstName.Text = dr[1].ToString();
                txtLastName.Text = dr[2].ToString();
                txtEmail.Text = dr[3].ToString();
                txtPhone.Text = dr[4].ToString();
            }
            cnc.connection().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("EXEC sp_UpdateCustomer @id=@p1, @firstname=@p2, @lastname=@p3, @email =@p4, @phone =@p5", cnc.connection());
            cmd.Parameters.AddWithValue("@p1", _customerID);
            cmd.Parameters.AddWithValue("@p2", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@p3", txtLastName.Text);
            cmd.Parameters.AddWithValue("@p4", txtEmail.Text);
            cmd.Parameters.AddWithValue("@p5", txtPhone.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your information has been updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cnc.connection().Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmCustomerPanel fr = new FrmCustomerPanel(_customerID);
            fr.Show();
            this.Hide();
        }
    }
}
