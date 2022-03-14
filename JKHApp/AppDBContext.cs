using System.Data;
using System.Data.SqlClient;

namespace JKHApp
{
    public class AppDBContext
    {
        SqlConnection sqlConn = new SqlConnection("Data Source=LAPTOP-538EEJNO\\MSSQLSERVER01;Database = JKHInfo; Integrated Security = True;");
        
        public void OpenConnection()
        {
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();
        }

        public void CloseConnection()
        {
            if (sqlConn.State == ConnectionState.Open)
                sqlConn.Close();
        }

        public SqlConnection GetConnection() => sqlConn;
    }
}