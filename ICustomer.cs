using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal interface CustomerMethods
    {
        public Customer Login();
        public void RegisterCustomer();
        public void Menu(Customer loggedInCustomer); //Förklara vidare senare
        public void UserList();

    }
}
