using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Admin : AllUsers
    {
        public static Dictionary<string, Admin> AdminUsers = new Dictionary<string, Admin>(); //_username, stored user
        private static int nextAdID = 1001; //Kolla så den räknar uppåt och inte ger ut samma nummer till alla
        private static int maxLoginAttempts = 3;

        public Admin(string username, int IDnumber, string firstname, string lastname, string password)
        {
            _username = username;
            _IDnumber = IDnumber;
            _firstname = firstname;
            _lastname = lastname;
            Password = password;
        }
    }

}
