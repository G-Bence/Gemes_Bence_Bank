﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankCard
    {
        double accountBalance;
        string cardNumber;

       /* public string CardNumber { get;  }
        public double AccountBalance { get; }*/
        public double AccountBalance { get => accountBalance;}
        public string CardNumber { get => cardNumber;}

        public BankCard(Owner owner, double accountBalance, string cardNumber)
        {
            this.accountBalance = accountBalance;
            this.cardNumber = cardNumber;
        }

        public bool Purchase(double amount)
        {
            if (accountBalance - amount >= 0)
            {
                accountBalance -= amount;
                return true;
            }
            return false;
        }   
    }
}
