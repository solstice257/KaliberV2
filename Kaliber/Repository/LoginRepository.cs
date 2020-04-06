using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Kaliber.Models;

namespace Kaliber.Repository
{
    public class LoginRepository
    {
        private readonly IConfiguration configuration;

        public LoginRepository(IConfiguration config)
        {
            this.configuration = config;
        }

        public void Login(User user)
        {
            string connectionstring = configuration.GetConnectionString("KaliberConnStr");
            string sql = $"SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();

            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            int result = (int)cmd.ExecuteScalar();
            if (result == 1)
            {
                user.LoggedIn = true;
            }
        }
    }
}
