using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace E_CommercePanel
{
    internal class sqlConnection
    {
        public SqlConnection connection()
        {
            string connectionString = Properties.Settings.Default.connection;
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            return connect;
        }
    }
}
