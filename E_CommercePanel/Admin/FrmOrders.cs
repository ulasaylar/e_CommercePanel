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
    public partial class FrmOrders : Form
    {
        sqlConnection cnc = new sqlConnection();
        public FrmOrders()
        {
            InitializeComponent();
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From dbo.ListOrders()",cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnc.connection().Close();
        }

        private void btnListOrderDetail_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC sp_ListOrderDetail @ID = @P1",cnc.connection());
            da.SelectCommand.Parameters.AddWithValue("@P1", txtOrderID.Text);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnc.connection().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtOrderID.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
        }

        private void btnListOrders_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From dbo.ListOrders()", cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnc.connection().Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAdminPanel fr = new FrmAdminPanel();
            fr.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
