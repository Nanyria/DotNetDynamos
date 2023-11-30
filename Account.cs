using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class Account
    {

        // Dictionary to hold user accounts (mapping user ID to bank accounts)
        private static Dictionary<int, List<Account>> userAccounts = new Dictionary<int, List<Account>>();  // userID, List<Account> //ändra till username för koherens
        public int AccountNumber {  get; set; }
        public decimal Balance { get; set; }

        public static void AddUser(int userId, List<Account>ac)
        {
            userAccounts.Add(userId, ac);
        }

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
        public void DisplayUserAccounts(int userID)  // Lägg till funktion för användare att döpa(namnge) account
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
        public static int GenerateAccountNumber(int userID)
        {
            Random random = new Random();
            int randomPart = random.Next(1000, 9999); // Generate a random 4-digit number

            // Combine the user ID with the random number to create a unique account number
            string accountNumberStr = userID.ToString() + randomPart.ToString();

            // Convert the combined string to an integer account number
            int accountNumber;
            if (int.TryParse(accountNumberStr, out accountNumber))
            {
                return accountNumber;
            }
            else
            {
                // Handle parsing failure or other error scenarios
                throw new InvalidOperationException("Failed to generate account number.");
            }
        }


    }
}
