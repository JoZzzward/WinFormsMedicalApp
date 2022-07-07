using System;
using System.Data;
using System.Data.SqlClient;

namespace JKHApp
{
    public class AppDbContext
    {
        string connectionString;
        public AppDbContext()
        {
            connectionString = "Data Source=LAPTOP-538EEJNO\\MSSQLSERVER01;Initial Catalog=МедицинскийЦентр;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public SqlConnection GetDBConnection() =>
            new SqlConnection(connectionString);

        public int InvokeSqlQuery(string sqlQuery)
        {
            SqlCommand cmd = new SqlCommand(sqlQuery, this.GetDBConnection()); 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt.Rows.Count;
        }
    }
}