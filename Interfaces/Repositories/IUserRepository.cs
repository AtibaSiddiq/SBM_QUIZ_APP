using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SBM_Quiz_App.Models;

namespace SBM_Quiz_App
{
    public interface IUserRepository
    {
        User GetUser(string password);
        User GetUserDetailsByName(string username);
        void AddUsers(User user); 
    }
}