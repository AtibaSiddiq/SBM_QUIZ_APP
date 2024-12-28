using SBM_Quiz_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBM_Quiz_App.Interfaces.Repositories
{
    public interface IQuestionRepository
    {
        List<Question> GetQuestions();
    }
}
