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
    public partial class FrmDiscounts : Form
    {
        private int _customerID;
        sqlConnection cnc = new sqlConnection();
        public FrmDiscounts(int customerID)
        {
            InitializeComponent();
            _customerID = customerID;
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

        private void FrmDiscounts_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ProductID,DiscountRate,StartDate,EndDate,Description FROM Tbl_Discounts WHERE IsActive = 1", cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
