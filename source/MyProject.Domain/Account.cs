using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.Domain
{
    public class Account
    {
        public string Id { get; private set; }
        public Money Balance { get; private set;}

        public Account(string id, Money balance)
        {
            if(string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id");
            }

            this.Id = id;
            this.Balance = balance;
        }

        public void Deposit(Money deposit)
        {
            if(!this.Balance.HasSameCurrency(deposit))
            {
                throw new InvalidOperationException("Cannot deposit different currency.");
            }

            this.Balance = this.Balance.Add(deposit);
        }

        public void Debit(Money deposit)
        {
            if (!this.Balance.HasSameCurrency(deposit))
            {
                throw new InvalidOperationException("Cannot deposit different currency.");
            }

            this.Balance = this.Balance.Subtract(deposit);
        }
    }
}