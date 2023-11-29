using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Admin : AllUsers
    {
        public override void Menu()
        {
            bool go = true;
            while (go)
            {
                Console.WriteLine("Admin Menu");
                Console.WriteLine("1. Create new user account.");
                Console.WriteLine("2. Delete user account.");
                Console.WriteLine("3. See User accounts.");
                Console.WriteLine("4. Change interest.");
                Console.WriteLine("5. Change exchange rate.");
                Console.WriteLine("6. Log out.");
                int svar = Convert.ToInt32(Console.ReadLine());
                switch (svar)
                {
                    case 1:
                        RegisterCustomer();
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
                        LogOut();
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again.");
                        break;
                }
            }
        }
    }
}
