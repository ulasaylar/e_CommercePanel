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

namespace E_CommercePanel.Customer
{
    public partial class FrmReviews : Form
    {
        sqlConnection cnc = new sqlConnection();
        private int _customerID;
        public FrmReviews(int customerId)
        {
            InitializeComponent();
            _customerID = customerId;
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

        private void FrmReviews_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM fn_ListProductReviews()", cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnc.connection().Close();
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text) || string.IsNullOrWhiteSpace(txtRate.Text))
            {
                MessageBox.Show("Please fill in all fields.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else {
                SqlCommand com = new SqlCommand("EXEC sp_AddReview @ProductId = @p1, @CustomerId = @p2, @rate = @p3, @comment = @p4", cnc.connection());
                com.Parameters.AddWithValue("@p1", txtProductId.Text);
                com.Parameters.AddWithValue("@p2", _customerID);
                com.Parameters.AddWithValue("@p3", txtRate.Text);
                com.Parameters.AddWithValue("@p4", rTxtReview.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Your review has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM fn_ListProductReviews()", cnc.connection());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cnc.connection().Close();
            }                
        }
    }
}
