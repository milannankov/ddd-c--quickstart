using MyProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Console
{
    public class DummyAccountRepository : IAccountRepository
    {
        private Account account101;
        private Account account201;

        public DummyAccountRepository()
        {
            this.account101 = new Account("101", new Money(Currency.BGN, 5000));
            this.account201 = new Account("201", new Money(Currency.USD, 10000));
        }

        public Account RetrieveAccount(string accountId)
        {
            if(accountId == "101")
            {
                return this.account101;
            }

            if (accountId == "201")
            {
                return this.account201;
            }

            return null;
        }

        public void SaveAccount(Account account)
        {
            
        }
    }
}
