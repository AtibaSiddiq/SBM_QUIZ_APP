using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBM_Quiz_App.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public char CorrectOption { get; set; }
        public int Score { get; set; } = 0;

        public Question(int id, string questionText, string optionA, string optionB, string optionC, string optionD, char correctOption)
        {
            QuestionID = id;
            QuestionText = questionText;
            OptionA = optionA;
            OptionB = optionB;
            OptionC = optionC;
            OptionD = optionD;
            CorrectOption = correctOption;
        }
        public Question()
        {
            
        }
    }

}
