using System.Collections.Generic;
using EVA.DTO;

namespace EVA.Data
{
    public interface ISurveyRepository
    {
        IEnumerable<Survey> GetAll();
        void Create(Survey survey);
        void Delete(Survey survey);
        void Update(Survey survey);
    }
}