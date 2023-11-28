using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class Account
    {
        public static Dictionary<int, string> CustomerAcc = new Dictionary<int, string>();
        public string AccountHolder {  get; set; }
        public decimal Balance { get; set; }
        public Account(string accountholder, decimal balance)
        {
            AccountHolder = accountholder;
            Balance = balance;
        }


        public class BankAccount
        {
            public int AccountNumber { get; set; }
            public decimal Balance { get; set; }
            // You can add more properties like account type, transaction history, etc., as needed
        }

        // Dictionary to hold user accounts (mapping user ID to bank accounts)
        private Dictionary<int, List<BankAccount>> userAccounts = new Dictionary<int, List<BankAccount>>();

        // Method to add a bank account for a customer
        public void AddBankAccount(int userID, BankAccount newAccount)
        {
            if (!userAccounts.ContainsKey(userID))
            {
                userAccounts[userID] = new List<BankAccount>();
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

        // Other methods and properties...
    }
}
