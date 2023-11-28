using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static DotNetDynamos.Account;

namespace DotNetDynamos
{
    internal class Customer : AllUsers
    {
        public static Dictionary<int, string> CustomerUsers = new Dictionary<int, string>(); // _IDnumber, _username
        private static int nextCuID = 1000;     // kolla med den
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

        //Check to see if we should register users only in Admin or if users should be able to register themselves
        public override void RegisterUser()
        {

            //Lägg till ett acc för nyreg kund

            Console.WriteLine("Welcome to User Registration!");

            // Get username from the user
            Console.Write("Enter user username: ");
            _username = Console.ReadLine();

            // Get first name from the user
            Console.Write("Enter user first name: ");
            _firstname = Console.ReadLine();

            //Get last name from the user
            Console.Write("Enter user last name: ");
            _lastname = Console.ReadLine();

            Console.Write("Enter your email address: ");
            Email = Console.ReadLine();
            // Get birthday
            Console.Write("Enter your birthday (YYYY-MM-DD):");
            Birthday = Console.ReadLine();

            // Get password from the user
            Console.Write("Password must contain:\n6-12 characters\nAt least one capitol letter\nAt least one digit\nAt least one symbol\nEnter password: ");
            Password = Console.ReadLine();

            _IDnumber = nextCuID++;
            
            CustomerUsers.Add(_IDnumber, _username);

            // Create a new bank account for the user
            Account newAccount = new Account
            {
                AccountNumber = Account.GenerateAccountNumber(_IDnumber),// Generate a unique account number
                Balance = 0 // Initial balance can be set as needed
            };

            // Assuming you have the user's unique ID (newUserID)
            Account.AddBankAccount(_IDnumber, newAccount); // Add the bank account to the user

            // Display user information
            Console.WriteLine($"User registered!\nUsername: {_username}\nID Number:{nextCuID}\nFirst name: {_firstname}\nLast name: {_lastname}\nEmail: {_email}\nBirthday: {Birthday}\nPassword: {Password}");

            

        }

        public override void Login()
        {
           
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

        static void NewAccount()
        {

        }

        static void Currency()
        {

        }

        static void AccountHistory()
        {

        }

        public void LogOut()
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


