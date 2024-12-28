using MySql.Data.MySqlClient;
using SBM_Quiz_App.Interfaces.Repositories;
using SBM_Quiz_App.Models;

namespace SBM_Quiz_App.Implementations.Repositories
{
    internal class QuestionRepository : IQuestionRepository
    {
        public List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>();

            using (var connection = Startup.Connection())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption FROM Quiz", connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string questionText = reader.GetString(1);
                    string optionA = reader.GetString(2);
                    string optionB = reader.GetString(3);
                    string optionC = reader.GetString(4);
                    string optionD = reader.GetString(5);
                    char correctOption = reader.GetString(6)[0];

                    questions.Add(new Question(id, questionText, optionA, optionB, optionC, optionD, correctOption));
                }

                reader.Close();
            }

            return questions;
        }
    }
}
