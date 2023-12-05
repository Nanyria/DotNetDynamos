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
        static void ShowBalance(AllUsers loggedInCustomer)
        {
            Account account = new Account();
            account.DisplayUserAccounts(loggedInCustomer._IDnumber);
            //Console.WriteLine("Here are your accounts");
            //foreach () //Acc in loggedInCustomer
            //{
            //    Console.WriteLine($"Account ID: {account.AccountNumber}\nBalance: {account.Balance}");
            //}

        }
    }
}
