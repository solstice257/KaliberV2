﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Kaliber.Models;
using Kaliber.Interfaces;

namespace Kaliber.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly IConfiguration configuration;
        string connectionstring;
        SqlConnection connection;
        public LoginRepository(IConfiguration config)
        { 
            this.configuration = config; 
            connectionstring = configuration.GetConnectionString("KaliberConnStr");
            connection = new SqlConnection(connectionstring);
        }

        public bool Exists(UserView user)
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
