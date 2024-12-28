using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBM_Quiz_App.Models
{
    public class User
    {
        public string firstname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public User(string firstname, string username, string password)
        {
            this.firstname = firstname;
            this.username = username;
            this.password = password;
        }

        public User()
        {

        }
    }
}