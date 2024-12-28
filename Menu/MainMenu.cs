using System;
using SBM_Quiz_App.Menu;
using SBM_Quiz_App.SignInOptions;

namespace SBM_Quiz_App
{
    class MainMenu
    {
        public static void Menu()
        { 
            Console.WriteLine("1. \t Register\n" +
                              "2. \t Login\n" +
                              "0. \t Logout");
            int option;
            var isSuccesful = int.TryParse(Console.ReadLine(), out option);
            if(isSuccesful)
            {
                switch(option)
                {
                    case 1: 
                    UserRegister.Register();
                    break;
                    case 2:
                    var loggedInUser = UserLogin.Login();
                    if (loggedInUser == null)
                    {
                        Console.WriteLine("Sorry but you have not registered. Please register before logging in.");
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Login successful");
                        Console.WriteLine("\t \t \t \tWelcome " + loggedInUser.username + " to SBM Quiz App");
                        UserMenu.Menu(loggedInUser);
                    }
                    break;
                    case 0:
                    Console.WriteLine("Thank you for using SBM Quiz App");
                    break;
                    default:
                    Console.WriteLine("Wrong input please try again.");
                    Menu();
                    break;
                }
            }
            else
            {
                Console.WriteLine("Wrong input please try again.");
                Menu();
            }
        }
    }
}