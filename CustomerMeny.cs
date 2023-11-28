using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class CustomerMeny
    {
        public int GetMenyChoice()
        {
            Console.WriteLine("Customer Meny");
            Console.WriteLine("View account and balance");
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
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                         break;
                    case 7:
                        break;

                    default:
                        Console.WriteLine("Wrong input, try again.");
                        break;
                }
            }

        static void ShowBalance()
        {

        }
        static void Transfer()
        {

        }

        static void TransferToOthers()
        {

        }

        static void NewAccount()
        {

        }

        static void Currency()
        {

        }

        static void AccountHistory()
        {

        }
        public void LogOut()
        {

        }
    }
}
