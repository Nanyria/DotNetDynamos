using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Customer : AllUsers
    {
        public override void UserList()
        {
            Console.WriteLine("Customer Users:");
            foreach (KeyValuePair<string, Customer> customerUser in CustomerUsers) //Lägg till ytterliggare val där man ser alla kunder och kan välja all se fullständig info om kund
            {
                Console.WriteLine($"ID Number: {customerUser.Value._IDnumber}");
                Console.WriteLine($"First Name: {customerUser.Value._firstname}");
                Console.WriteLine($"Last Name: {customerUser.Value._lastname}");
                Console.WriteLine($"Email: {customerUser.Value.email}");
                Console.WriteLine($"Birthday: {customerUser.Value.birthday}");
                Console.WriteLine("Accounts:");
                if (customerUser.Value._accounts.Count == 0)
                {
                    Console.WriteLine("No account");
                }
                else
                {
                    foreach (Account account in customerUser.Value._accounts)
                    {
                        Console.WriteLine($"Account Number: {account._accountNumber}");
                        Console.WriteLine($"Account Name: {account._accountName}");
                        Console.WriteLine($"Balance: {account._balance}");
                        Console.WriteLine($"Currency: {account._currency}");
                    }
                }
                Console.WriteLine("---------------------------");
            }
        }

        public void PreCreatedCustomers()
        {
            //Skapa lista att lagra användare i som stefan snackade om?
        }
    }
}
