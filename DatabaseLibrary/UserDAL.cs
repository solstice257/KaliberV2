using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Interfaces.DTO;

namespace DatabaseLibrary
{
    class UserDAL
    {
        SqlConnection connection;
        public UserDAL()
        {
            connection = new SqlConnection("Server=mssql.fhict.local;Database=dbi441576_kaliber;User ID=dbi441576_kaliber;Password=henk123");
        }
        public void Register(User user)
        {
            try
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO Users(Username, Email, Password, Type) VALUES (@Username, @Email, @Password, @Type)";
                cmd.Parameters.AddWithValue("Username", user.Username);
                cmd.Parameters.AddWithValue("Email", user.Email);
                cmd.Parameters.AddWithValue("Password", user.Password);
                cmd.Parameters.AddWithValue("Type", User);
                cmd.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public bool CheckIfUserExists(User user)
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
