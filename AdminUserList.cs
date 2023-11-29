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
            foreach (KeyValuePair<int, string> adminUser in AdminUsers)
            {
                Console.WriteLine($"ID: {adminUser.Key}, Username: {adminUser.Value}");
            }
        }
    }
}
