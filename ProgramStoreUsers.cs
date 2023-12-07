using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Program
    {
        static void StoreUsers(string[] args)
        {
            Customer user1 = new Customer
            (
                "User1",
                5001,
                "Johan",
                "Johansson",
                "Password1!",
                "Johan@Johansson.se",
                "1978-01-01",
                new List<Account>
                {
                    new Account(50011234, "MainAccount", "SEK", 1234),
                }
            );

            Customer user2 = new Customer
            (
                "User2",
                5002,
                "Anna",
                "Andersson",
                "Password2!",
                "Anna@Andersson.se",
                "1988-01-01",
                 new List<Account>
                {
                    new Account(50028977, "MainAccount", "SEK", 1234),
                    new Account(50011265, "SavingAccount", "EUR", 1234)
                }
            );

            Customer user3 = new Customer
            (
                "User3",
                5003,
                "Alice",
                "Karlsson",
                "Password3!",
                "Alice@Karlsson.se",
                "1998-01-01",
                 new List<Account>
                {
                    
                }
            );

            Admin ad1 = new Admin
                (
                    "Admin1",
                    1001,
                    "Karl",
                    "Larsson",
                    "Adminmin!2"
                );

            Customer.CustomerUsers.Add("User1", user1);
            Customer.CustomerUsers.Add("User2", user2);
            Customer.CustomerUsers.Add("User3", user3);
            Admin.AdminUsers.Add("Admin1", ad1);

            user1.Login();
            user1.Menu();

            user2.Login();
            user2.Menu();

            user3.Login();
            user3.Menu();

            //ad1.Login();
            //ad1.Menu();



        }
    }
}
