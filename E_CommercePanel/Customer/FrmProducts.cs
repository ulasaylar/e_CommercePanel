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
    public partial class FrmProducts : Form
    {
        sqlConnection cnc = new sqlConnection();
        private int _customerID;
        public FrmProducts(int customerID)
        {
            InitializeComponent();
            _customerID = customerID;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ProductId,ProductName, Description, Price, StockQuantity FROM Tbl_Products", cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmCustomerPanel fr = new FrmCustomerPanel(_customerID);
            fr.Show();
            this.Hide();
        }
    }
}
