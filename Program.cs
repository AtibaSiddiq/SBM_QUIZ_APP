namespace SBM_Quiz_App
{
    class Program
    {
        public static void Main(string[] args)
        {
            Startup.CreateDatabase();
            Console.WriteLine("Hello and welcome to SBM Quiz App"); 
            Startup.CreateUserTable();
            Startup.CreateQuizTable();
            Startup.InsertQuestions();
            MainMenu.Menu();
        }
    }
}
