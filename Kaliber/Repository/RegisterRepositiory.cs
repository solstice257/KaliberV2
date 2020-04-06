using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Kaliber.Models;



namespace Kaliber.Repository
{
    class RegisterRepositiory
    {
        string User = "User";
        private readonly IConfiguration configuration; 

        public RegisterRepositiory(IConfiguration config)
        {
            this.configuration = config;
        }

        public void AddUsers(User user)
        {
            string connectionstring = configuration.GetConnectionString("KaliberConnStr");

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();
            SqlCommand com = connection.CreateCommand();
            com.CommandText = "INSERT INTO Users(Username, Email, Password, Type) VALUES (@Username, @Email, @Password, @Type)";
            com.Parameters.AddWithValue("Username", user.Username);
            com.Parameters.AddWithValue("Email", user.Email);
            com.Parameters.AddWithValue("Password", user.Password);
            com.Parameters.AddWithValue("Type", User);
            com.ExecuteNonQuery();

            connection.Close();
        }
    }
}
