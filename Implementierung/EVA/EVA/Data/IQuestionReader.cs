using System.Collections.Generic;
using EVA.DTO;

namespace EVA.Data
{
    public interface IQuestionReader
    {
        IEnumerable<Question> GetAll();
        IEnumerable<Question> GetBySurvey(Survey survey);
    }
}