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


            Customer c1 = new Customer
            (
                "Kund1",
                5013,
                "Lars",
                "Göransson",
                "Kunden!1",
                "lars@goransson.se",
                "1976-05-03"
            );
            Customer.CustomerUsers.Add("Kund1", c1);





        }
    }
}
