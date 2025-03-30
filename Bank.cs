using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank
    {
        private List<BankAccount> accounts;

        public Bank(int maxAccountCount) {
            accounts = new List<BankAccount>(maxAccountCount);
        }

        //Add to array 
        //FIX THE CODE BECASUE I THINK THAT THE NEW ACCOUNTS ARE NULL 
        public BankAccount NewAccount(Owner owner, double creditLimit) {
            BankAccount newAccount;
            if (creditLimit == 0) {
                newAccount = new SavingAccount(owner);
                if (newAccount != null)
                {
                    accounts.Add(newAccount);
                }
                return newAccount;
            }

            else
            {
                newAccount = new CreditAccount(owner, creditLimit);
                if (newAccount != null)
                {
                    accounts.Add(newAccount);
                    //I think that the append doesn't work
                }
                return newAccount;
            }
        }

        public void TESTER()
        {
            Console.WriteLine(accounts[0].GetType());
            /*
            foreach (var account in accounts)
            {
                Console.WriteLine(account.ToString());
            }*/
        }

        public double TotalBalance(Owner owner) {
                

            double sum = 0;
            if (accounts != null)
            {
                foreach (var account in accounts)
                {
                    if (account != null)
                    {
                        sum += account.Balance;
                    }
                }
            }
            return sum;
            
            //return accounts.Sum(x => x.Balance);

        }

        public BankAccount MaximalBalanceAccount(Owner owner) {
            BankAccount maxBankAccount;
            if (accounts != null)
            {
                maxBankAccount = accounts[0];

                for (int i = 1; i < accounts.Count; i++)
                {
                    if (accounts[i] != null && accounts[i].Balance > maxBankAccount.Balance)
                    {
                        maxBankAccount = accounts[i];
                    }
                }
                return maxBankAccount;
            }

            else
            {
                return null;
            }


        }

        public double TotalCreditLimit()
        {
            double sum = 0;
            if (accounts != null)
            {
                foreach (var account in accounts)
                {
                    if (account != null)
                    {
                        sum += account.Balance;
                        if (account != null && account is CreditAccount)
                        {
                            sum += (account as CreditAccount).Creditlimit;
                        }
                    }
                }
            }

            return sum;
        }
    }
}
