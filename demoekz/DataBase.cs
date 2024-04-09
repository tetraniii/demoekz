using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace demoekz
{
    class DataBase
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-SF6SJHQ\SQLEXPRESS; Initial Catalog=demoekz; Integrated Security=true");

        public void openConnection()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return SqlConnection;
        }
    }
}
