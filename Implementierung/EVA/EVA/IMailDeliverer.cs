using EVA.DTO;

namespace EVA
{
    public interface IMailDeliverer
    {
        void Send(Mail mail);
    }
}