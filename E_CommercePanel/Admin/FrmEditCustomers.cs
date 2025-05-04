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
    public partial class FrmEditCustomers : Form
    {
        public FrmEditCustomers()
        {
            InitializeComponent();
        }
        sqlConnection cnc = new sqlConnection();
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("EXEC sp_NewCustomer @id=@p1,@firstname=@p2,@lastname=@p3,@email=@p4,@phone=@p5",cnc.connection());
            com.Parameters.AddWithValue("@p1", txtId.Text);
            com.Parameters.AddWithValue("@p2", txtFirstName.Text);
            com.Parameters.AddWithValue("@p3", txtLastName.Text);
            com.Parameters.AddWithValue("@p4", txtEmail.Text);
            com.Parameters.AddWithValue("@p5", txtPhone.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("Customer Added","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.fn_GetCustomers()", cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnc.connection().Close();
        }

        private void FrmEditCustomers_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.fn_GetCustomers()", cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnc.connection().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("EXEC sp_UpdateCustomer @id=@p1, @firstname=@p2,@lastname=@p3,@email=@p4,@phone=@p5 ", cnc.connection());
            com.Parameters.AddWithValue("@p1", txtId.Text);
            com.Parameters.AddWithValue("@p2", string.IsNullOrWhiteSpace(txtFirstName.Text) ? (object)DBNull.Value : txtFirstName.Text);
            com.Parameters.AddWithValue("@p3", string.IsNullOrWhiteSpace(txtLastName.Text) ? (object)DBNull.Value : txtLastName.Text);
            com.Parameters.AddWithValue("@p4", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text);
            com.Parameters.AddWithValue("@p5", string.IsNullOrWhiteSpace(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("Customer Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.fn_GetCustomers()", cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnc.connection().Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("EXEC sp_DeleteCustomer @id = @p1",cnc.connection());
            com.Parameters.AddWithValue("@p1", txtId.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("Customer Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.fn_GetCustomers()", cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnc.connection().Close();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            FrmAdminPanel fr = new FrmAdminPanel();
            fr.Show();
            this.Hide();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            txtFirstName.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
        }
    }
}
