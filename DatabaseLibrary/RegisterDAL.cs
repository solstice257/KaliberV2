using Kaliber.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DatabaseLibrary
{
    class RegisterDAL
    {
        SqlConnection connection;
        string User = "User";
        public RegisterDAL()
        {
            connection = new SqlConnection("Server=mssql.fhict.local;Database=dbi441576_kaliber;User ID=dbi441576_kaliber;Password=henk123");
        }
        public bool AddedUser(User user)
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
    }
}
