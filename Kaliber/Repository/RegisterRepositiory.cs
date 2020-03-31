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

            string sql = $"INSERT INTO Users VALUES {username}, {password}, {email}";
            SqlCommand com = new SqlCommand(sql);
            com.ExecuteNonQuery();

            connection.Close();
        }
    }
}
