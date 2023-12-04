using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Customer : AllUsers
    {
        static void NewAccount(Dictionary<int, List<Account>> userAccounts, int id) //29/11
        {
            Console.WriteLine("Open new Account");
            // login?
            List<Account> accounts = userAccounts[id];   // Bring up list from dictionary in otder to add new account.
            Console.WriteLine("How much money do you want to deposit?");
            decimal balance = GetValidDecimall(); // kollar om det är siffra.
            Account newAccount = new Account
            {
                AccountNumber = Account.GenerateAccountNumber(id),// Generate a unique account number
                Balance = balance,
            };
            ////Account.AddBankAccount(id, newAccount); eller ↓↓
            accounts.Add(newAccount);
            Console.WriteLine("Congrats! Your account has been created succesfully!");
            Console.WriteLine($"Here is your new accout: " +$"\nAccount Number: {newAccount.AccountNumber}" +
                              $"\nBalance:{newAccount.Balance}");
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
