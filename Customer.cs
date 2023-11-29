using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static DotNetDynamos.Account;

namespace DotNetDynamos
{
    internal partial class Customer : AllUsers
    {
        public static Dictionary<int, string> CustomerUsers = new Dictionary<int, string>(); // _IDnumber, _username
        private static int nextCuID = 1000;     // kolla så att den fortsätter räkna, inte ger ut samma nummer varje gång
        private static int maxLoginAttempts = 3;
        private string _email;
        private DateTime _birthday;
        public string Email
        {
            get => _email;
            set
            {
                if (IsValidEmail(value))
                {
                    _email = value;
                }
                else
                {
                    Console.WriteLine("Invalid email format. Please enter a valid email address.");
                }
            }
        }
        protected static bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
        
        //Fix so that user has to enter bithdate until correct bd has been entered
        public string Birthday
        {
            get => _birthday.ToString();
            set
            {
                if (DateTime.TryParse(value, out DateTime date))
                {
                    _birthday = date;
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please enter a valid date.");
                }
            }
        }

        public override void Menu()
        {
            bool go = true;
            while (go)
            {
                Console.WriteLine("Customer Meny");
            Console.WriteLine("View account and balance");
            Console.WriteLine("2. Transfer money between accounts");
            Console.WriteLine("3. Transfer money to other Customer");
            Console.WriteLine("4. Open new account");
            Console.WriteLine("5. Another currency");
            Console.WriteLine("6. Account history");
            Console.WriteLine("7. Logg out");

            Console.Write("Choose meny: ");
            int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShowBalance();
                        break;
                    case 2:
                        Transfer();
                        break;
                    case 3:
                        TransferToOthers();
                        break;
                    case 4:
                        NewAccount();
                        break;
                    case 5:
                        Currency();
                        break;
                    case 6:
                        AccountHistory();
                        break;
                    case 7:
                        LogOut();
                        break;

                    default:
                        Console.WriteLine("Wrong input, try again.");
                        break;
                }
            }
        }

        static void ShowBalance()
        {

        }

        static void Transfer()
        {

        }

        static void TransferToOthers()
        {

        }

        static void NewAccount() //29/11
        {

        }

        static void Currency()
        {

        }

        static void AccountHistory()
        {

        }


    
        public override void UserList()     

        {
            Console.WriteLine("Customer Users:");
            foreach (KeyValuePair<int, string> customerUser in CustomerUsers)
            {
                Console.WriteLine($"ID: {customerUser.Key}, Username: {customerUser.Value}");
            }
        }
    }
}


