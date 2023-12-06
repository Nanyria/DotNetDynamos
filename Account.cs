using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Account
    {
        public int _accountNumber { get; set; }
        public string _accountName { get; set; }
        public string _currency { get; set; }
        public double _balance { get; set; }

        public Account(int Accountnumber, string Accountname, string Currency, double Balance)
        {
            _accountNumber = Accountnumber;
            _accountName = Accountname;
            _currency = Currency;
            _balance = Balance;
        }
        // Dictionary to hold user accounts (mapping user ID to bank accounts)
        public static Dictionary<Customer, List<Account>> userAccounts = new Dictionary<Customer, List<Account>>();  


        static Customer customer = new Customer();
        static AllUsers loggedInCustomer = customer.Login();




        //public static void AddUser(int userId, List<Account>ac)
        //{
        //    userAccounts.Add(userId, ac);
        //}


        // Method to add a bank account for a customer
        public static void AddBankAccount(AllUsers loggedInCustomer) //Add new acc
        {

            if (!userAccounts.ContainsKey(loggedInCustomer))
            {
                userAccounts[userID] = new List<Account>();
            }

            userAccounts[userID].Add(MainAccount);
        }

        // Method to display user bank accounts
        public static void DisplayUserAccounts(AllUsers loggedInCustomer)  // Lägg till funktion för användare att döpa(namnge) account
        {
            if (userAccounts.ContainsKey((Customer)loggedInCustomer))
            {
                Console.WriteLine($"Bank Accounts for User ID: {loggedInCustomer}");
                foreach (List<Account> account in userAccounts.Values)
                {
                    Console.WriteLine($"Account Number: {account._accountNumber}, Balance: {account._balance}");
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
