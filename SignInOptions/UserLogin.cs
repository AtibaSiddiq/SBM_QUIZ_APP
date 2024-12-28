using System.Reflection.Emit;
using SBM_Quiz_App.Models;

namespace SBM_Quiz_App.SignInOptions
{
    public class UserLogin
    {
        static IUserRepository userRepo = new UserRepository();
        public static User Login()
        {
            Console.WriteLine("Enter your password");
            string pwd = Console.ReadLine();
            var success = userRepo.GetUser(pwd);
            return success;
        }
    }
}