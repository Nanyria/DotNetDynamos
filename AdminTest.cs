using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class AdminTest : AllUsers
    {
        public static Dictionary<string, AdminTest> AdminUsers = new Dictionary<string, AdminTest>(); //_username, 
        private static int nextAdID = 1001;
        private static int maxLoginAttempts = 3;

        public AdminTest (string username, int IDnumber, string firstname, string lastname, string password)
        {
            _username = username;
            _IDnumber = IDnumber;
            _firstname = firstname;
            _lastname = lastname;
            Password = password;
        }

        public override void RegisterUser()
        {
            Console.WriteLine("Welcome to User Registration!");

            // Get username from the user
            Console.Write("Enter your username: ");
            _username = Console.ReadLine();

            // Get first name from the user
            Console.Write("Enter your first name: ");
            _firstname = Console.ReadLine();

            //Get last name from the user
            Console.Write("Enter your last name: ");
            _lastname = Console.ReadLine();

            // Get password from the user
            Console.Write("Password must contain:\n6-12 characters\nAt least one capitol letter\nAt least one digit\nAt least one symbol\nEnter password: ");
            Password = Console.ReadLine();

            _IDnumber = nextAdID++;

            AdminTest newAdmin = new AdminTest(_username, _IDnumber, _firstname, _lastname, Password);

            AdminUsers.Add(_username, newAdmin);

            // Display user information
            Console.WriteLine($"User registered!\nUsername: {_username}\nID Number:{_IDnumber}\nFirst name: {_firstname}\nLast name: {_lastname}\nPassword: {Password}");
        }
        public static void RegisterCustomer()
        {
            //Customer customer = new Customer();
            //customer.RegisterUser();

        }

        public override void UserList()
        {
            //Console.WriteLine("Customer Users:");
            //foreach (KeyValuePair<int, string> adminUser in AdminUsers)
            //{
            //    Console.WriteLine($"ID: {adminUser.Key}, Username: {adminUser.Value}");
            //}
        }


        public override void Login()
        {
            AdminTest loggedInAdmin = null;
            int loginAttempts = 0;
            while (loggedInAdmin == null)
            {
                Console.WriteLine("Username:");
                string enteredName = Console.ReadLine();

                // Validate if the entered username exists in AdminUsers dictionary
                if (AdminUsers.ContainsKey(enteredName))
                {
                    Console.WriteLine("Password:");
                    string enteredPassword = Console.ReadLine();

                    // Perform password validation here; replace the placeholder with your logic
                    if (ValidateAdminPassword(enteredName, enteredPassword)) // Example password validation
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome, " + enteredName + "!");
                        // Further actions after successful login can be added here
                        loggedInAdmin = AdminUsers[enteredName];
                    }
                    else
                    {
                        loginAttempts++;
                        Console.WriteLine($"Incorrect password. You have {maxLoginAttempts - loginAttempts} attempts remaining.");
                    }
                }
                else
                {
                    Console.WriteLine("Username not found.");
                }
            }
            if (loggedInAdmin == null)
            {
                Console.WriteLine("Maximum login attempts reached. Please contact support.");
            }

        }


        // Method to validate admin password
        private bool ValidateAdminPassword(string enteredName, string enteredPassword)
        {

            // Check if the userID exists in the dictionary
            if (AdminUsers.ContainsKey(enteredName))
            {
                // Retrieve the stored password corresponding to the userID
                AdminTest storedAdminTest = AdminUsers[enteredName];

                return enteredPassword == storedAdminTest.Password;
            }
            else
            {
                // UserID not found, handle the case (throw an exception, return false, etc.)
                // For example:
                throw new ArgumentException("User ID not found.");
            }
        }


        public override void Menu()
        {
            bool go = true;
            while (go)
            {
                Console.WriteLine("Customer Menu");
                Console.WriteLine("1. Create new user account.");
                Console.WriteLine("2. Delete user account.");
                Console.WriteLine("3. See User accounts.");
                Console.WriteLine("4. Change interest.");
                Console.WriteLine("5. Change exchange rate.");
                Console.WriteLine("6. Log out.");
                int svar = Convert.ToInt32(Console.ReadLine());
                switch (svar)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        go = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again.");
                        break;
                }
            }

        }
        public void LogOut()
        {
            Console.WriteLine("1. Log Out");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Login(); // Log Out
                    break;
                case 2:
                    Environment.Exit(0); // Exit the program
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again."); // Stay in the loop
                    break;
            }
        }
    }
}
