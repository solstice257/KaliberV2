using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Kaliber.Models;
using Kaliber.Interfaces;


namespace Kaliber.Repository
{
    public class RegisterRepositiory : IRegisterRepository
    {
        string User = "User";
        private readonly IConfiguration configuration;
        string connectionstring;
        SqlConnection connection;

        public RegisterRepositiory(IConfiguration config)
        {
            this.configuration = config;
            connectionstring = configuration.GetConnectionString("KaliberConnStr");
            connection = new SqlConnection(connectionstring);
        }

        public bool AddedUser(UserView user)
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
