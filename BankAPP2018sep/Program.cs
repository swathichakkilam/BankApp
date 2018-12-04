using System;

namespace BankAPP2018sep
{
    class Program
    {
        static void Main(string[] args)
        {
            //account is the reference in memory to the Account object that has been created 
           // var account1 = VirtualBank.CreateAccount("user1@bank.com", TypeofAccount.Savings,0);
            //account1.Deposit(100000.50M);
            //Console.WriteLine($"AN:{account1.AccountNumber},AccType:{account1.AccountType},Balance:{account1.Balance},EA:{account1.EmailAddress}");


            /*if we want to pick and choose optional parameters and not follow the same 
            order in which all parameters are declared  then we need to mention the optional parameter in the key value pair format*/
           // var account2 = VirtualBank.CreateAccount("user2@bank.com", InitialDeposit:500.50M);
           /* {
               // AccountNumber = 229,
                AccountType = "Checking",
                //Balance = 9000,
                EmailAddress = "user2@bank.com"
            };*/
           // account2.Deposit(2000.54M);
           // account2.Withdraw(555M);
          //  Console.WriteLine($"AN:{account2.AccountNumber},AccType:{account2.AccountType},Balance:{account2.Balance},EA:{account2.EmailAddress}");


            // Console.WriteLine("Hello World!");
           
    //Trying to create a Menu that displays some options for user to select from in the Bank Application
                 Console.WriteLine("************************");
            Console.WriteLine("Welcome to my Bank App");
            Console.WriteLine("*************************");
            Console.WriteLine("0.Exit");
            Console.WriteLine("1.Create an Account");
            Console.WriteLine("2.Deposit Money");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("4.Print all Accounts");
            Console.Write("Please Select an option: ");
            var option = Console.ReadLine();
            #region
            switch (option)
            {
                case "0":
                    return;
                case "1":
                    Console.Write("Email Address:");
                    var emailaddress= Console.ReadLine();
                    /*Converting an Enum to an Array to enable looping through
                    the array of enum to access the values of datatype or valuetype enum one at a time*/
                    //the keyword typeof in C# gets the user the underlying type of(eg:int or type or bool etc)  that type 
                  
             //accountype is the array that holds the values of type enum that have been converted to a string array 
                    var accounttype = Enum.GetNames(typeof(TypeofAccount));
                    for(var i=0;i<accounttype.Length;i++)
                    {
                        /*everything inside the flower brackets in an inline is like 
                        a placeholder which will be replaced when priting to the console*/
                        Console.WriteLine($"{i + 1} {accounttype[i]}");
                    }
                    Console.Write("Select an Account Type:");
                    //reading the user selected option and storing it in acctypeoption variable
                    var acctypeoption = Convert.ToInt32( Console.ReadLine());

                    /*Converting the selected option into respective zero based index option of the array 
                    //and grabbing the respective account type string and forcibly requesting compiler to convert 
                    //the array value at the respective index to an Enum Type using 'typeof'keyword
                    //to get to the underlying type of the data(here it is of type TypeofAccount)
                    //the Parse keyword runs a method named Parse that 
                    //takes any string value and converts it into the desired type
                    //basically trying to Parse the users option back into an Enum 
                    //note : in C# every class generally inherits from a Parent Class called Object
                    
                    Enum.Parse(typeof(TypeofAccount), accounttype[acctypeoption - 1]);*/

                    /*Using Generics to Parse function in a more generalized manner instead of 
                    default Parse operation to give the user the user specific output of Type TypeofAccount(Enum)
                    and storing it in a new variable  accountType which holds the Enum value selected by BankUser*/
                     var Accounttype = Enum.Parse<TypeofAccount>(accounttype[acctypeoption - 1]);
                    /*accepting Amount from user and reading it into the variable Initial Deposit*/
                    Console.Write("Enter the Amount to Deposit:");
                    var InitialDeposit = Convert.ToDecimal( Console.ReadLine());

                    var account =VirtualBank.CreateAccount(emailaddress, Accounttype,InitialDeposit);
                    Console.WriteLine($"AN:{account.AccountNumber},AT:{account.AccountType},Balance:{account.Balance}");
                    break;
                       
                default:
                    break;
                    #endregion
            }

        }
    }
}
