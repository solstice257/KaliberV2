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
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Users(Username, Email, Password, Type) VALUES (@Username, @Email, @Password, @Type)";
            cmd.Parameters.AddWithValue("Username", user.Username);
            cmd.Parameters.AddWithValue("Email", user.Email);
            cmd.Parameters.AddWithValue("Password", user.Password);
            cmd.Parameters.AddWithValue("Type", User);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
