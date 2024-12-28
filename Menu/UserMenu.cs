using SBM_Quiz_App.Implementations.Service;
using SBM_Quiz_App.Models;

namespace SBM_Quiz_App.Menu
{
    public class UserMenu
    {
        public static void Menu(User loggedInUser)
        {
            QuestionService quiz = new QuestionService();
            Console.WriteLine("Choose the correct option to the question");
            Console.WriteLine();
            quiz.Start();
        }
    }
}