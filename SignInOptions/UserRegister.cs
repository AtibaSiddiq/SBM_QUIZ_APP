using SBM_Quiz_App.Menu;
using SBM_Quiz_App.Models;

namespace SBM_Quiz_App
{
    public class UserRegister
    {
        static IUserRepository userRepo = new UserRepository();
        public static void Register()
        {
            Console.WriteLine("Enter your first name: ");
            string firstname = Console.ReadLine();
            var search = userRepo.GetUserDetailsByName(firstname);
            if (search != null)
            {
                Console.WriteLine("The name already exists. Please try again");
                Register();
            }
            else
            {
                Console.WriteLine("Enter your username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                string pwd = Console.ReadLine();
                User user = new User(firstname, username, pwd);
                userRepo.AddUsers(user);
                Console.WriteLine("Registration is successful");
                Console.WriteLine("\t \t \t \tWelcome " + user.username + "to SBM Quiz App");
                UserMenu.Menu(user);
                Console.ResetColor();
            }
        }
    }
}