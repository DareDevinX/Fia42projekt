using EVA.DTO;

namespace EVA
{
    public interface ILoginService
    {
        User Login(Account account);
        void Logout();
    }
}