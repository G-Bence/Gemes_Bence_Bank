using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal abstract class BankAccount : BankingService
    {
        private double balance;

        public double Balance { get => balance; set => balance = value; }

        protected BankAccount(Owner owner) : base(owner)
        {

        }

        public void Deposit (double amount)
        {
            balance += amount;

        }

        public abstract bool Withdraw (double amount);

        public BankCard NewCard (string cardNumber)
        {
            return new BankCard(Owner, balance, cardNumber);
        }
    }
}
