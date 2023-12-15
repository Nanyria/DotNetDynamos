using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal interface IAdminMethods
    {
        public Admin Login();
        public void RegisterCustomer();
        public void Menu(Admin loggedInAdmin); //Förklara vidare senare
        public void UserList();
    }
}
