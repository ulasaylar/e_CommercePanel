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
    public partial class FrmOrderHistory : Form
    {
        private int _customerID;
        sqlConnection cnc = new sqlConnection();
        public FrmOrderHistory(int customerID)
        {
            InitializeComponent();
            _customerID = customerID;
        }

        private void FrmOrderHistory_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.fn_ListOrderHistoryByCustomerID(@p1)", cnc.connection());
            da.SelectCommand.Parameters.AddWithValue("@p1", _customerID);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnc.connection().Close();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            FrmCustomerPanel fr = new FrmCustomerPanel(_customerID);
            fr.Show();
            this.Hide();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
