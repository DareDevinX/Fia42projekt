using System.Collections.Generic;
using EVA.DTO;

namespace EVA.Data
{
    public interface IAppointedSurveyRepository
    {
        IEnumerable<AppointedSurvey> GetByTeacher(Teacher teacher);
        IEnumerable<AppointedSurvey> Start(AppointedSurvey appointedSurvey);
    }
}