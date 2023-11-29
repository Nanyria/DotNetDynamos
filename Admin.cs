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
            Admin loggedInAdmin = null;
            int loginAttempts = 0;

            while (loggedInAdmin == null)
            {
                Console.WriteLine("Username:");
                string enteredName = Console.ReadLine();

                // Validate if the entered username exists in AdminUsers dictionary
                if (AdminUsers.ContainsKey(int.Parse(enteredName)))
                {
                    Console.WriteLine("Password:");
                    string enteredPassword = Console.ReadLine();

                    // Find the key (ID) associated with the entered username
                    int userID = int.Parse(enteredName);

                    // Perform password validation here; replace the placeholder with your logic
                    if (ValidateAdminPassword(userID, enteredPassword)) // Example password validation
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome, " + enteredName + "!");
                        // Further actions after successful login can be added here
                        loggedInAdmin = new Admin();
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
        //public override void Login()
        //{
        //    Admin loggedInAdmin = null;
        //    int loginAttempts = 0;
        //    while (loggedInAdmin == null)
        //    {
        //        Console.WriteLine("Username:");
        //        string enteredName = Console.ReadLine();

        //        // Validate if the entered username exists in AdminUsers dictionary
        //        if (AdminUsers.ContainsValue(enteredName))
        //        {
        //            Console.WriteLine("Password:");
        //            string enteredPassword = Console.ReadLine();

        //            // Find the key (ID) associated with the entered username
        //            int userID = AdminUsers.FirstOrDefault(x => x.Value == enteredName).Key;

        //            // Perform password validation here; replace the placeholder with your logic
        //            if (ValidateAdminPassword(userID, enteredPassword)) // Example password validation
        //            {
        //                Console.Clear();
        //                Console.WriteLine("Welcome, " + enteredName + "!");
        //                // Further actions after successful login can be added here
        //                loggedInAdmin = new Admin();
        //                loggedInAdmin._IDnumber = userID;
        //                loggedInAdmin._username = enteredName;
        //            }
        //            else
        //            {
        //                loginAttempts++;
        //                Console.WriteLine($"Incorrect password. You have {maxLoginAttempts - loginAttempts} attempts remaining.");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Username not found.");
        //        }
        //    }
        //    if (loggedInAdmin == null)
        //    {
        //        Console.WriteLine("Maximum login attempts reached. Please contact support.");
        //    }

        //}
        

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
                Console.WriteLine("Admin Menu");
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
                        RegisterCustomer();
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
                        LogOut();   
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again.");
                        break;
                }
            }



        }
    }
}
