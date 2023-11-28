﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class Account
    {
        // Dictionary to hold user accounts (mapping user ID to bank accounts)
        private static Dictionary<int, List<Account>> userAccounts = new Dictionary<int, List<Account>>();
        public int AccountNumber {  get; set; }
        public decimal Balance { get; set; }



        // Method to add a bank account for a customer
        public static void AddBankAccount(int userID, Account newAccount)
        {
            if (!userAccounts.ContainsKey(userID))
            {
                userAccounts[userID] = new List<Account>();
            }

            userAccounts[userID].Add(newAccount);
        }

        // Method to display user bank accounts
        public void DisplayUserAccounts(int userID)
        {
            if (userAccounts.ContainsKey(userID))
            {
                Console.WriteLine($"Bank Accounts for User ID: {userID}");
                foreach (var account in userAccounts[userID])
                {
                    Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");
                }
            }
            else
            {
                Console.WriteLine("User has no bank accounts.");
            }
        }
        public static int GenereateAccountNumber()
        {
            //Accnumber = customernumber+1000?
        }


    }
}
