﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class SavingAccount : BankAccount
    {
        static double baseInterest;

        //public static double Interest { get; set; }
        public static double Interest { get => baseInterest; set => baseInterest = value; }

        public SavingAccount(Owner owner) : base (owner)
        {
            Interest = baseInterest;
        }

        public override bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public void AddInterest()
        {
            Balance += Balance * (Interest / 100);
        }

        public override string? ToString()
        {
            return $"{Owner.Owners_Name}'s Saving Accounts\nBalance: {Balance}$";
        }
    }
}
