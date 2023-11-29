using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class Test
    {
        List<Account> ac = new List<Account> ();
        public Dictionary<int, string> AdminUsers = new Dictionary<int, string>();
        public Dictionary<int, AllUsers> ad = new Dictionary<int, AllUsers>(); // userId, List
        List<AllUsers> users = new List<AllUsers>();
        public Dictionary<int, string> CustomerUsers = new Dictionary<int, string>();
        public Dictionary<int, List<Account>> userAccounts = new Dictionary<int, List<Account>>();

        public Test()
        {
            //users.Add(new Admin { 
            //    _username = "admin",
            //    _firstname = "Admin",
            //    _lastname = "User",

            //});
            Admin a1 = new Admin()
            {
                _username = "admin",
                _firstname = "Admin",
                _lastname = "User",
                Password = "Admin12!",
                _IDnumber = 1235,
            };
            Customer c1 = new Customer()
            {
                _username = "cus",
                _firstname = "Customer",
                _lastname = "User",
                Password = "Cus123!",
                _IDnumber = 1111,
            };

            Admin.AddUser(a1._IDnumber, a1.Password);
            Admin.AddUser(1234, "HejHej2!");
            //Customer.AddUser(c1._username, c1.Password, c1._IDnumber);
            //string username, string password, int IDnumber

            //Customer.AddUser(c1._IDnumber, c1.Password);
        }
        public void TestTest()
        {
            Admin ad = new Admin();
            ad.Login();
            ad.Menu();

            //Customer cus = new Customer();
            //cus.Login();
        }
    }
}
