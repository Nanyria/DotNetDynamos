using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class CustomerMeny
    {
        public void customerMeny()
        {
            Console.WriteLine("Customer Meny");
            string menu1 = "1. View account and balance";
            string menu2 = "2. Transfer money between accounts";
            string menu3 = "3. Transfer money to other Customer";
            string menu4 = "4. Open new account";
            string menu5 = "5. Another currency";
            string menu6 = "6. Account history";


            Console.WriteLine("\n\t" + menu1 + "\n\t" + menu2 + "\n\t" + menu3 + "\n\t" + menu4 + "\n\t" + menu5+ "\n\t" + menu6 + "\n\t");

            
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
    }
}
