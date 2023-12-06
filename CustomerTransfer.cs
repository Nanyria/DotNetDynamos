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
        static void Transfer(AllUsers loggedInCustomer)
        {
            // List<Account> = int AccountNumber, decimal Balance
            Console.WriteLine("Here are your accounts: ");
            ShowBalance(userAccounts, id);
            Console.WriteLine("Which account do you want to transfer from?");
            Console.WriteLine("Please press \"enter\" to go to meny.");
            Account sourceAccount = null;
            Account targetAccount = null;
            List<Account> accounts = userAccounts[id];
            while (true)
            {
                int transferFrom = GetValidInt();
                if (userAccounts.ContainsKey(id))       // wondering to create method to check if the key in the dictnionary.
                {
                    accounts = userAccounts[id];
                    sourceAccount = accounts.Find(e => e.AccountNumber == transferFrom);
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
                    int transferTo = GetValidInnt();
                    targetAccount = accounts.Find(e => e.AccountNumber == transferFrom);

                    Console.WriteLine("How much money do you want to transfer?");
                    decimal money = GetValidDecimal();
                    if (money < 0 || money > sourceAccount.Balance)
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

        static int GetValidInnt()
        {
            int number;
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out number)) 
                { 
                    Console.WriteLine("Invalid input. Please enter en integer.");
                    return -1;
                }
            }
            return number;
        }
     
        static int GetValidInt() // This goes back to meny if the user pressed enter.
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
        static decimal GetValidDecimal()
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

        static void TransferToOthers()
        {

        }
    }
}
