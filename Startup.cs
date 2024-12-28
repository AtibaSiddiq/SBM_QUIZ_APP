using System;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using SBM_Quiz_App.Models;


namespace SBM_Quiz_App
{
    class Startup
    {
        public static void CreateDatabase()
        {
            string connectionString = "Server=localhost; user = root; password = root;";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // SQL command to create the database 'questions'
                string createDatabaseQuery = "CREATE DATABASE if not exists Quiz_Questions;";
                var command = new MySqlCommand(createDatabaseQuery, connection);
                command.ExecuteNonQuery();
            }
        }
        public static MySqlConnection Connection()
        {
            // SQL command to create connections
            string connectionStrings = "server = localhost; userID = root; database = Quiz_Questions; password = root";
            return new MySqlConnection(connectionStrings);
        }
        public static void CreateTable(string tableQuerry)
        {
            // SQL command to create table
            using (var connection = Connection())
            {
                connection.Open();
                var command = new MySqlCommand(tableQuerry, connection);
                int row = command.ExecuteNonQuery();
            }
        }
        public static void CreateQuizTable()
        {
            var query = "create table if not exists Quiz(QuestionID int, QuestionText varchar(255), OptionA varchar(255), OptionB varchar(255), OptionC varchar(255), OptionD varchar(255), CorrectOption char(1));";
            CreateTable(query);
        }
        public static void InsertQuestions()
        {
            using(var connection = Connection())
            {
                connection.Open();
                var query = new MySqlCommand("INSERT INTO Quiz(QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption) VALUES" +
                "(1,'Who won the FIFA World Cup in 2018?', 'Germany', 'France', 'Brazil', 'Argentina', 'B');" +
                "INSERT INTO Quiz(QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption) VALUES" +
                "(2,'What year did Nigeria gain independence?', '1960', '1975', '1980', '1990', 'A');" +
                "INSERT INTO Quiz(QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption) VALUES" +
                "(3,'What is the chemical symbol for water?', 'H2', 'O2', 'H20', 'HO2', 'C');" +
                "INSERT INTO Quiz(QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption) VALUES" +
                "(4,'Which soccer player is known as The King of Football?', 'Lionel Messi', 'Diego Maradona', 'Pelé', 'Cristiano Ronaldo', 'C');" +
                "INSERT INTO Quiz(QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption) VALUES" +
                "(5,'Who was the first President of Nigeria?', 'Nnamdi Azikiwe', 'Tafawa Balewa', 'Olusegun Obasanjo', 'Goodluck Jonathan', 'A');" +
                "INSERT INTO Quiz(QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption) VALUES" +
                "(6,'What is the powerhouse of the cell in biology?', 'Nucleus', 'Ribosomes', 'Mitochondria', 'Golgi Apparatus', 'C');" +
                "INSERT INTO Quiz(QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption) VALUES" +
                "(7,'Which country hosted the first FIFA World Cup?', 'Brazil', 'Uruguay', 'Italy', 'England', 'B');" +
                "INSERT INTO Quiz(QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption) VALUES" +
                "(8,'When was the amalgamation of Nigeria?', '1919', '1915', '1992', '1914', 'D');" +
                "INSERT INTO Quiz(QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption) VALUES" +
                "(9,'What is Newtons First Law of Motion?', 'Law of Gravity', 'Action-Reaction', 'Inertia', 'Law of Force', 'C');" +
                "INSERT INTO Quiz(QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption) VALUES" +
                "(10,'Which Nigerian city is known as the Coal City?', 'Lagos', 'Enugu', 'Port Harcourt', 'Niger', 'B');", connection);
                query.ExecuteReader();
            }
        }
        public static void CreateUserTable()
        {
            var querry = "create table if not exists Users(Username varchar(50), Password varchar(50));";
            CreateTable(querry);
        }
    }
}