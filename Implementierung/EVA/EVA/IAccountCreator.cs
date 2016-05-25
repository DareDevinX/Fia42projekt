using System.Collections.Generic;
using EVA.DTO;

namespace EVA
{
    public interface IAccountCreator
    {
        IEnumerable<Account> CreateAnonymousAccountsFor(Class cl);

    }
}
