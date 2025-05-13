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

namespace E_CommercePanel.Admin
{
    public partial class FrmReviews : Form
    {
        sqlConnection cnc = new sqlConnection();
        public FrmReviews()
        {
            InitializeComponent();
        }

        private void FrmReviews_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM fn_ListProductReviews()", cnc.connection());
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
