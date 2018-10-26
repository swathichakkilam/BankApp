using System;

namespace BankAPP2018sep
{
    class Program
    {
        static void Main(string[] args)
        {
            //account is the reference in memory to the Account object that has been created 
            var account1 = new Account()
            {
              
                AccountType = "Savings",
                EmailAddress = "test@test.com"
            };
            account1.Deposit(10000.50M);
            Console.WriteLine($"AN:{account1.AccountNumber},AccType:{account1.AccountType},Balance:{account1.Balance},EA:{account1.EmailAddress}");


            var account2 = new Account()
            {
               // AccountNumber = 229,
                AccountType = "Checking",
                //Balance = 9000,
                EmailAddress = "user2@bank.com"
            };
            account2.Deposit(2000.54M);
            account2.Withdraw(555M);
            Console.WriteLine($"AN:{account2.AccountNumber},AccType:{account2.AccountType},Balance:{account2.Balance},EA:{account2.EmailAddress}");


            Console.WriteLine("Hello World!");
        }
    }
}
