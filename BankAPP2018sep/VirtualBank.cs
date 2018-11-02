using System;
using System.Collections.Generic;
using System.Text;

namespace BankAPP2018sep
{
    /// <summary>
    /// The VirtualBank Class is Static meaning only one instance of the class is created 
    /// which is one shared memory among 
    /// various customers holding an account with the bank
    /// </summary>
    /*when the class is declared static 
     * no method in that class can be instantiated hence every method (member) in that class
     * needs to be static */
    static class VirtualBank
    {
        #region Methods 
        /// <summary>
        /// Method to Create an Account with the Bank
        /// </summary>
        /// <param name="EmailID"> Email Address of the User</param>
        /// <param name="Accounttype">What type of Account User wants to create at the Bank</param>
        /// <param name="InitialDeposit">The Amount Customer wishes to Deposit with the Bank</param>
        /// <returns>returns the newly created account to the user</returns>
        /*The return type of CreateAccount method 
         * is the class Account type  as the account will be created
         with the bank*/
         //since Virtual Bank is a static class CreateAccount method is also static
        public static Account CreateAccount(string EmailID, string Accounttype, decimal InitialDeposit)
        {
            var account = new Account
            {
                EmailAddress = EmailID,
                AccountType = Accounttype

            };
            /*since balance cannot be set by the customer and it has to be set via Bank
             * we mention a condition that if initial amount deposited is more than zero bank deposits in
             the respective Bank account created for the customer*/

            if (InitialDeposit > 0)
            {
                account.Deposit(InitialDeposit);
            }
            return account;
        }
        #endregion
    }
}