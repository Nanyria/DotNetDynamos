using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Admin : AllUsers
    {
        public override void UserList()
        {
            Console.WriteLine("Customer Users:");
            foreach (KeyValuePair<string, Admin> adminUser in AdminUsers)
            {
                Console.WriteLine($"ID Number: {adminUser.Value._IDnumber}");
                Console.WriteLine($"First Name: {adminUser.Value._firstname}");
                Console.WriteLine($"Last Name: {adminUser.Value._lastname}");
                Console.WriteLine("---------------------------");
            }
        }
    }
}
