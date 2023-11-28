using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class Customer : AllUsers
    {
        public static Dictionary<int, string> AdminUsers = new Dictionary<int, string>();
        private static int nextAdID = 1001;
        private static int maxLoginAttempts = 3;

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


            AdminUsers.Add(_IDnumber, _username);

            // Display user information
            Console.WriteLine($"User registered!\nUsername: {_username}\nID Number:{_IDnumber}\nFirst name: {_firstname}\nLast name: {_lastname}\nPassword: {Password}");
        }
        public static void RegisterCustomer()
        {
            Customer customer = new Customer();
            customer.RegisterUser();

        }

        public override void UserList()
        {
            Console.WriteLine("Customer Users:");
            foreach (KeyValuePair<int, string> adminUser in AdminUsers)
            {
                Console.WriteLine($"ID: {adminUser.Key}, Username: {adminUser.Value}");
            }
        }


        public override void Login()
        {
            Customer loggedInAdmin = null;
            int loginAttempts = 0;
            while (loggedInAdmin == null)
            {
                Console.WriteLine("Username:");
                string enteredName = Console.ReadLine();

                // Validate if the entered username exists in AdminUsers dictionary
                if (AdminUsers.ContainsValue(enteredName))
                {
                    Console.WriteLine("Password:");
                    string enteredPassword = Console.ReadLine();

                    // Find the key (ID) associated with the entered username
                    int userID = AdminUsers.FirstOrDefault(x => x.Value == enteredName).Key;

                    // Perform password validation here; replace the placeholder with your logic
                    if (ValidateAdminPassword(userID, enteredPassword)) // Example password validation
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome, " + enteredName + "!");
                        // Further actions after successful login can be added here
                        loggedInAdmin = new Customer();
                        loggedInAdmin._IDnumber = userID;
                        loggedInAdmin._username = enteredName;
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
        private bool ValidateAdminPassword(int userID, string enteredPassword)
        {
            // Fetch the stored password associated with the userID from your data source (e.g., AdminUsers dictionary)
            string storedPassword = string.Empty;

            // Check if the userID exists in the dictionary
            if (AdminUsers.ContainsKey(userID))
            {
                // Retrieve the stored password corresponding to the userID
                storedPassword = AdminUsers[userID];
            }
            else
            {
                // UserID not found, handle the case (throw an exception, return false, etc.)
                // For example:
                throw new ArgumentException("User ID not found.");
            }

            // Compare the stored password with the entered password
            bool isValidPassword = (enteredPassword == storedPassword);

            return isValidPassword;
        }
    

        public override void Menu()
        {
            bool go = true;
            while(go)
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
    }
}
