using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Kaliber.Models;


namespace Kaliber.Repository
{
    internal class RegisterRepositiory
    {
        int ID = 2;
        string user = "User";
        private readonly IConfiguration configuration; 

        public RegisterRepositiory(IConfiguration config)
        {
            this.configuration = config;

        }

        public void AddUsers(string username, string password, string email)
        {
            string connectionstring = configuration.GetConnectionString("KaliberConnStr");

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();
            SqlCommand com = connection.CreateCommand();
            com.CommandText = "INSERT INTO Users(Username, Email, Password, Type) VALUES (@Username, @Email, @Password, @Type)";
            com.Parameters.AddWithValue("Username", username);
            com.Parameters.AddWithValue("Email", email);
            com.Parameters.AddWithValue("Password", password);
            com.Parameters.AddWithValue("Type", user);
            com.ExecuteNonQuery();

            connection.Close();
        }
    }
}
