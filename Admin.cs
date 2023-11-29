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
        public static Dictionary<int, string> AdminUsers = new Dictionary<int, string>();
        private static int nextAdID = 1001;
        private static int maxLoginAttempts = 3;


        public static void AddUser(int userId, string password)
        {
            AdminUsers.Add(userId, password);
        
        }

       

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
