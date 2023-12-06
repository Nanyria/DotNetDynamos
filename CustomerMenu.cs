using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Customer : AllUsers
    {
        public override void Menu(AllUsers loggedInCustomer)
        {
            bool go = true;
            while (go)
            {
                Console.WriteLine("Customer Meny");
                Console.WriteLine("1. View account and balance");
                Console.WriteLine("2. Transfer money between accounts");
                Console.WriteLine("3. Transfer money to other Customer");
                Console.WriteLine("4. Open new account");
                Console.WriteLine("5. Another currency");
                Console.WriteLine("6. Account history");
                Console.WriteLine("7. Logg out");

                Console.Write("Choose meny: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShowBalance(loggedInCustomer); // Dictionary<int, List<Account>> userAccounts, int id
                        break;
                    case 2:
                        Transfer(loggedInCustomer); // Dictionary<int, List<Account>> userAccounts, int id
                        break;
                    case 3:
                        TransferToOthers(loggedInCustomer);
                        break;
                    case 4:
                        NewAccount(loggedInCustomer);
                        break;
                    case 5:
                        Currency(loggedInCustomer);
                        break;
                    case 6:
                        AccountHistory(loggedInCustomer);
                        break;
                    case 7:
                        LogOut(loggedInCustomer);
                        break;

                    default:
                        Console.WriteLine("Wrong input, try again.");
                        break;
                }
            }
        }
    }
}
