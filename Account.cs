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
        public decimal _balance { get; set; } //Decimal eller double? Sätt decimal - mer noggrann, kan använda fler nollor, sen avrunda till 2 dec 

        public Account(int Accountnumber, string Accountname, string Currency, decimal Balance)
        {
            _accountNumber = Accountnumber;
            _accountName = Accountname;
            _currency = Currency;
            _balance = Balance;
        }
        /// <summary>
        /// Tror det är bättre om vi fixar felmeddelande i CreateAcc ist då vi inte behöver konstruktor i längden /N
        /// </summary>
        //public Account() : this(00, "No name provided", "No currency provided", 00)
        //{
        //}
        // Dictionary to hold user accounts (mapping user ID to bank accounts)
        private static Dictionary<Customer, List<Account>> userAccounts = new Dictionary<Customer, List<Account>>();  // userID, List<Account>



        static Customer customer = new Customer();
        static AllUsers loggedInCustomer = customer.Login();




        //public static void AddUser(int userId, List<Account>ac)
        //{
        //    userAccounts.Add(userId, ac);
        //}


        // Method to add a bank account for a customer
        
        //if - no account > Main acc
        //if else - Display list Acc + Choice Create new Acc
        /// <summary>
        //if (no acc)
        //{
        //addMainAcc
        //    }
        //else if (MainAcc = true)
        //{
        //DisplayUserAcC
        //Choice > Create New
        //if (choice)
        //Private Acc
        //Savings Acc //Bara valet, v har inte skivit koden än, går att kommentera ut så länge
        // then > Add Info
        // then > If accepted > Show info
        //Console.Clear
        //return to Menu
        //}
        /// </summary>
        /// <param name="loggedInCustomer"></param>
        public static void AddBankAccount(AllUsers loggedInCustomer) //Add new acc, metametod, ska inte känna av specifik användare /N
        {
            if (!userAccounts.ContainsKey(userID))
            {
                userAccounts[userID] = new List<Account>();
            }

            userAccounts[userID].Add(MainAccount);

        }

        // Method to display user bank accounts
        public static void DisplayUserAccounts(AllUsers loggedInCustomer)  // Lägg till funktion för användare att döpa(namnge) account
        {
            if (userAccounts.ContainsKey(customer))
            {
                Console.WriteLine($"Bank Accounts for User ID: {loggedInCustomer}");
                foreach (List<Account> account in userAccounts.Values)
                {
                    Console.WriteLine($"Account Number: {loggedInCustomer.}, Balance: {account.Balance}");
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
