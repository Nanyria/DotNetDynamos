using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Customer : AllUsers
    {
        static void Transfer(AllUsers loggedInCustomer, Dictionary<int, List<Account>> userAccounts, int id)
        {
            // List<Account> = int AccountNumber, decimal Balance
            Console.WriteLine("Here are your accounts: ");
            Account.DisplayUserAccounts(loggedInCustomer);
            Console.WriteLine("Which account do you want to transfer from?");
            Console.WriteLine("Please press \"enter\" to go to meny.");
            Account sourceAccount = null;
            Account targetAccount = null;
            List<Account> accounts = Account.userAccounts[(Customer)loggedInCustomer];
            while (true)
            {
                int transferFrom = GetValidIntOrGoToMenu();
                if (userAccounts.ContainsKey(id))       // wondering to create method to check if the key in the dictionary.
                {
                    accounts = userAccounts[id];
                    sourceAccount = accounts.Find(e => e._accountNumber == transferFrom);
                    Console.WriteLine("You want to transfer money from account {0}", transferFrom + ", correct?");
                    Console.WriteLine("[1]. Yes.");
                    Console.WriteLine("[2]. No.");
                    if (int.TryParse(Console.ReadLine(), out int confirm) && (confirm == 1 || confirm == 2))
                    {
                        if (confirm == 1)
                        {
                            
                        }
                        else
                        {
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("Felaktigt inmatning. Ange 1 eller 2.");
                       
                    }
                   



                    Console.WriteLine("Which account do you want to transfer to?");
                    int transferTo = GetValidInt();
                    targetAccount = accounts.Find(e => e._accountNumber == transferFrom);

                    Console.WriteLine("How much money do you want to transfer?");
                    decimal money = GetValidDecimal();
                    if (money < 0 || money > sourceAccount._balance)
                    {
                        Console.WriteLine("Invalid transfer amount.");
                        return;
                    }
                    sourceAccount.Balance -= money;
                    targetAccount.Balance += money;
                }
                else
                {

                }

               


               

                

            }
        }

        static int GetValidIntOrGoToMenu() // This goes back to meny if the user pressed enter.
        {
            Customer cus = null;
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                cus.Menu();
                return 0;
            }
            else
            {
                if (int.TryParse(input, out int number))
                    return number;
                else
                {
                    Console.WriteLine("Invalid input. Please enter integer.");
                    return GetValidInt();
                }
            }
        }
        public static int GetValidInt()
        {
            int choice;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out choice))
                    Console.WriteLine("Invalid input. Please enter an integer.");
                else
                    return choice;
            }
        }
        public static string GetValidString()
        {
            string value = String.Empty;
            while (String.IsNullOrEmpty(value))
            {
                value = Console.ReadLine();
                if (String.IsNullOrEmpty(value))
                    Console.WriteLine("Please insert");
            }
            return value;
        }
        public static decimal GetValidDecimal()
        {
            decimal money;
            while (true)
            {
                if (!decimal.TryParse(Console.ReadLine(), out money))
                    Console.WriteLine("Invalid input. Please enter an integer.");
                else
                    return money;
            }
        }
        static void TransferToOthers()
        {

        }
    }
}
