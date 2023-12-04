using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Admin : AllUsers
    {

        public override AllUsers Login()
        {
            Admin loggedInAdmin = null;
            int loginAttempts = 0;
            int maxLoginAttempts = 3; // Assuming a maximum of 3 login attempts

            while (loginAttempts < maxLoginAttempts && loggedInAdmin == null)
            {
                Console.WriteLine("Username:");
                string enteredName = Console.ReadLine();

                // Validate if the entered username exists in CustomerUsers dictionary
                if (AdminUsers.ContainsKey(enteredName))
                {
                    Console.WriteLine("Password:");
                    string enteredPassword = Console.ReadLine();

                    // Perform password validation here
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

            return loggedInAdmin;



        }


        // Method to validate admin password
        private bool ValidateAdminPassword(string enteredName, string enteredPassword)
        {

            // Check if the userID exists in the dictionary
            if (AdminUsers.ContainsKey(enteredName))
            {
                // Retrieve the stored password corresponding to the userID
                Admin storedAdmin = AdminUsers[enteredName];

                return enteredPassword == storedAdmin.Password;
            }
            else
            {
                // UserID not found, handle the case (throw an exception, return false, etc.)
                // For example:
                throw new ArgumentException("User ID not found.");
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
