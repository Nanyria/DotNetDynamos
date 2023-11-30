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
                Console.WriteLine("---------------------------");
            }
        }
    }
}
