using System;
using System.Collections.Generic;
using System.Text;

namespace BankAPP2018sep
{
    /// <summary>
    /// Defines a Bank Application and its respective Code
    /// </summary>
    
    enum TypeofAccount
    {
        Savings,
        Checking,
        CurrentDeposit,
        Loan
    }
    /// <summary>
    /// Enum stores its variables as numbers hence its a value type
    /// a number is associated with each of its variables 
    /// here it is Savings with 0 as its default number 
    /// </summary>
    class Account
    {
        /// <summary>
        /// For the bank to generate an Acc number it needs to refer to last Account number and generate by 
        /// adding one digit to give a new Account number to a new customer  hence to keep track of last 
        /// Account number and to keep it hidden from current customer we use variable LastAccNum
        /// </summary>
        /* To Update the account number that already exists by 1 add the static keyword to avoid assigning 0 to last accou
        nt number everytime the constructor is called */
        private static int LastAccNum = 0;
        #region Properties 
        /// <summary>
        /// Account Number given to each individual customer holding an account with the bank in Numeric Format
        /// </summary>
        //not allowing set to the property as user cannot write to or make changes to AccountNumber only read from it 
        public int AccountNumber { get; }

        /// <summary>
        /// AccountType can be Savings or Checking Account
        /// </summary>
        public TypeofAccount AccountType { get; set; }

        /// <summary>
        /// Balance denotes the amount available for withdrawal in the bank 
        /// </summary>
        // Balance is a read only property  with write only credentials given to Bank and not to every customer 
        /* hence its set is mentioned as private 
         Write Only credentials given to Bank because without bank having access to write to Balance the customers Balance cannot be updated everytime
         a Deposit needs to be made or whenever the Deposit method is called */
        public decimal Balance { get; private set; }
        /// <summary>
        /// EmailAddress is a variable holding alphanumeric characters that display the  email contact information of the Account holder
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Particular Info of the Day and time the account has been created by the account holder at the Bank 
        /// </summary>
        public DateTime CreatedDate { get; }
        #endregion

        #region Constructor
        //Constructor for Account Class 
        //only within a constructor even though a property is read only it can be assigned values
        public Account()
        {
            //Updated that is preincremented account number assigned to AccountNumber 
            AccountNumber = ++LastAccNum;
            CreatedDate = DateTime.Now;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Method to Deposit money into Customers Account
        /// </summary>
        /// <param name="Amount"> Amount in total to be deposited to the Account</param>
        public void Deposit(decimal Amount)
        {
            Balance = Balance + Amount;
        }
        public void Withdraw(decimal Amount)
        {
            Balance -= Amount;
        }
        #endregion
    }
}
