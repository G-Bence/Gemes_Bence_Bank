using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class CreditAccount : BankAccount
    {
        double creditlimit;
        //public double Balance { get; }

        public double Creditlimit { get; }

        public CreditAccount(Owner owner, double creditlimit): base(owner)
        {
            this.creditlimit = creditlimit;
        }

        public override bool Withdraw(double amount)
        {
            if (this.Balance - amount >= creditlimit) {
                this.Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
