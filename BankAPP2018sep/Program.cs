using System;

namespace BankAPP2018sep
{
    class Program
    {
        static void Main(string[] args)
        {
            //account is the reference in memory to the Account object that has been created 
            var account1 = VirtualBank.CreateAccount("user1@bank.com", "Savings",0);
            account1.Deposit(100000.50M);
            Console.WriteLine($"AN:{account1.AccountNumber},AccType:{account1.AccountType},Balance:{account1.Balance},EA:{account1.EmailAddress}");


            /*if we want to pick and choose optional parameters and not follow the same 
            order in which all parameters are declared  then we need to mention the optional parameter in the key value pair format*/
            var account2 = VirtualBank.CreateAccount("user2@bank.com", InitialDeposit:500.50M);
           /* {
               // AccountNumber = 229,
                AccountType = "Checking",
                //Balance = 9000,
                EmailAddress = "user2@bank.com"
            };*/
           // account2.Deposit(2000.54M);
            account2.Withdraw(555M);
            Console.WriteLine($"AN:{account2.AccountNumber},AccType:{account2.AccountType},Balance:{account2.Balance},EA:{account2.EmailAddress}");


           // Console.WriteLine("Hello World!");
        }
    }
}
