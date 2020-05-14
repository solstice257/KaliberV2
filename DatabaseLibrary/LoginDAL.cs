using Kaliber.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DatabaseLibrary
{
    class LoginDAL
    {
        SqlConnection connection;
        public LoginDAL()
        {
            connection = new SqlConnection("Server=mssql.fhict.local;Database=dbi441576_kaliber;User ID=dbi441576_kaliber;Password=henk123");
        }

        public bool Exists(User user)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            int result = (int)cmd.ExecuteScalar();
            if (result == 1)
            {
                return true;
            }
            return false;
        }
    }
}
