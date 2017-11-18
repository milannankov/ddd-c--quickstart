using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.Domain
{
    public interface IAccountRepository
    {
        Account RetrieveAccount(string accountId);
        void SaveAccount(Account account);
    }
}