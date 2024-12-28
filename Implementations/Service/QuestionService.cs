using Google.Protobuf.WellKnownTypes;
using SBM_Quiz_App.Implementations.Repositories;
using SBM_Quiz_App.Interfaces.Service;
using SBM_Quiz_App.Models;

namespace SBM_Quiz_App.Implementations.Service
{
    internal class QuestionService : QuestionRepository
    {
        Question quiz = new();
        public void Start()
        {
            var questions = GetQuestions();
            foreach (var question in questions)
            {
                Console.WriteLine($"{question.QuestionID}: {question.QuestionText}");
                Console.WriteLine($"a) {question.OptionA}\t" + $"b) {question.OptionB}\t" + $"c) {question.OptionC}\t" + $"d) {question.OptionD}");
                Console.Write("Your answer: ");
                char userAnswer;
                var isSuccesful = char.TryParse(Console.ReadLine(), out userAnswer);
                if (isSuccesful)
                {
                    if(char.ToLower(userAnswer) == 'a' || char.ToLower(userAnswer) == 'b' || char.ToLower(userAnswer) == 'c' || char.ToLower(userAnswer) == 'd')
                    {
                        if (char.ToLower(userAnswer) == char.ToLower(question.CorrectOption))
                        {
                            quiz.Score++;
                        }
                        else
                        {

                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input. Next Question:");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Input. Please try again");
                }
            }
            Console.WriteLine($"Congratulations.\nYou scored {quiz.Score} out of {questions.Count}");
        }
    }

}
