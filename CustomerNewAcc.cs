using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Customer : AllUsers
    {
        static void NewAccount(AllUsers loggedInCustomer) //29/11
        {
            Console.WriteLine("Open new Account");
            // login?
        List<Account> accounts = Account.userAccounts[loggedInCustomer];   // Bring up list from dictionary in order to add new account.
            Console.WriteLine("How much money do you want to deposit?");
            double balance = Convert.ToDouble(Console.ReadLine()); // kollar om det är siffra.
            Account newAccount = new Account
            {
                _accountNumber = Account.GenerateAccountNumber(loggedInCustomer._IDnumber),// Generate a unique account number
                _currency = "",
                _accountName = "",
                 _balance = balance,
            };
            ////Account.AddBankAccount(id, newAccount); eller ↓↓
            accounts.Add(newAccount);
            Console.WriteLine("Congrats! Your account has been created succesfully!");
            Console.WriteLine($"Here is your new accout: " + $"\nAccount Number: {newAccount._accountNumber}" +
                              $"\nBalance:{newAccount._balance}");
        }
        static decimal GetValidDecimall()
        {
            decimal money;
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out money))
                {
                    Console.WriteLine("Invalid input. Please enter integer.");
                    return -1;
                }
            }
            return money;
        }
    }
}
