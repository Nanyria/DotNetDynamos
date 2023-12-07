using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class AccountManagementSystem
    {
        public static void AssignRole()   // Eftersom vi har två login system, är det bättre med den här?
        {
            Console.WriteLine("Choose customer or Admin."
                + "\n[1. Customer]"
                + "\n[2. Admin]");
            Customer cus = new Customer();
            Admin ad = new Admin();
            bool go = true;
            while (go)
            {
                int choice = Validator.GetValidInt();
                switch (choice)
                {       // Vi behöver har cus.Login() här eller i Menu, före switch-satsen. 
                    case 1:
                        cus.Menu();
                        break;
                    case 2:
                        ad.Menu();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Bye!");
                        Console.ReadKey();
                        go = false;
                        break;
                    default:
                        Console.WriteLine("Insert 1 or 2.");
                        break;
                }
            }
        }
        public static void Assign(List<AllUsers> users)     // Man loggar in först(Bara en login system) och kommer till varsin meny. 
        {                                                   // StoredUsers behöver vara "AllUsers a1 = new Admin" etc.
            Customer cus = new Customer();
            Admin ad = new Admin();
            foreach (AllUsers user in users)
            {
                if (user is Customer)
                {
                    cus.Menu(); 
                }
                else
                {
                    ad.Menu();
                }
            }
        }
    }
}
