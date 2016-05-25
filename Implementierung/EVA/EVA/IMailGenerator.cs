using EVA.DTO;

namespace EVA
{
    public interface IMailGenerator
    {
        Mail GenerateFrom(Account account, User user);
        Mail GenerateFrom(AppointedSurvey survey);
    }
}