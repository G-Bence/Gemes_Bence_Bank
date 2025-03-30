namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            owner.Owners_Name = "Nagy Lajos";

            Console.WriteLine(owner.Owners_Name);


            Bank bank = new Bank(2);

            BankAccount account_1 = bank.NewAccount(owner, 10000);
            account_1.NewCard("123456789");
            BankAccount account_2 = bank.NewAccount(owner, 0);

            account_1.Deposit(500);
            account_2.Deposit(800);


            BankCard card_1 = new BankCard(owner, 5000, "987654321");
            card_1.Purchase(1000);
            Console.WriteLine(card_1.AccountBalance);


            Console.WriteLine("\n--------------------\n");
            bank.TESTER();

            Console.WriteLine(account_1.Withdraw(0) ? "The account has been withdraw" : "The accoint has NOT been withdraw");

            Console.WriteLine(account_1.Balance);
            Console.WriteLine(account_2.Balance);

            Console.WriteLine("\n--------------------\n");
            
            Console.WriteLine(bank.TotalBalance(owner));
            Console.WriteLine(bank.MaximalBalanceAccount(owner).ToString());
            Console.WriteLine(bank.TotalCreditLimit());
           
            

        }
    }
}
