using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Admin : AllUsers
    {
        public static void AddUser(int userId, string password)
        {
            AdminUsers.Add(userId, password);

        }
    }
}
