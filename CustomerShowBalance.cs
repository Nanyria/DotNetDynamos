using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Customer : AllUsers
    {
        // This is to show the balance on all accounts.
        static void ShowBalance(Dictionary<int, List<Account>> userAccounts, int id)
        {
            if (userAccounts.ContainsKey(id))       
            {
                if (userAccounts[id].Count <= 0) 
                {
                    Console.WriteLine("You do not have yet any accounts.");
                    return;
                }
                Console.WriteLine("Here are your accounts");
                foreach (var account in userAccounts[id])  
                {
                    Console.WriteLine($"Account ID: {account.AccountNumber}\nBalance: {account.Balance}");   
                }
            }
            else 
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}
