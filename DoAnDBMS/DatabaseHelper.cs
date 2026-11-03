
using System;
using System.Data;
using System.Data.SqlClient;

namespace DoAnDBMS
{
    internal class DatabaseHelper
    {
        private static string connectionString =
            @"Data Source=localhost;Initial Catalog=DB_DoAnDBMS;Integrated Security=False;User ID=sa;Password=123456;Encrypt=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
