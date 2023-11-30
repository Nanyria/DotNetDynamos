using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Customer : AllUsers
    {

        static Customer()
        {
            Customer user1 = new Customer("User1", 1001, "Johan", "Johansson", "Password1!");
            Customer user2 = new Customer("user2", 1002, "Anna", "Andersson", "Password2!");
            Customer user3 = new Customer("user3", 1003, "Alice", "Karlsson", "Password3!");

            CustomerUsers.Add(user1._username, user1);
            CustomerUsers.Add(user2._username, user2);
            CustomerUsers.Add(user3._username, user3);
        }


    }
}
