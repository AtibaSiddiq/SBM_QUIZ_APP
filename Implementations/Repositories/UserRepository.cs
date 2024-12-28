using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SBM_Quiz_App.Models;

namespace SBM_Quiz_App
{
    public class UserRepository : IUserRepository
    {
        public User GetUserDetailsByName(string name)
        {
            User user = null;
            using (var connection = Startup.Connection())
            {
                connection.Open();
                var query = $"select * from Users where Username = '{name}';";
                var command = new MySqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user = new User();
                        user.firstname = reader.GetString(0);
                        user.username = reader.GetString(1);
                    }
                    return user;
                }
            }
        }
        public User GetUser(string password)
        {
            User user = null;
            using (var connection = Startup.Connection())
            {
                connection.Open();
                var query = $"select * from Users where Password = '{password}';";
                var command = new MySqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user = new User();
                        user.username = reader.GetString(0);
                        user.password = reader.GetString(1);
                    }
                    return user;
                }
            }
        }
        public void AddUsers(User user)
        {
            using (var connection = Startup.Connection())
            {
                connection.Open();
                var query = new MySqlCommand($"INSERT INTO Users(Username, Password) VALUES('{user.firstname}','{user.password}');",connection);
                query.ExecuteReader();
            }
        }
    }
}