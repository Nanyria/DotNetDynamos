using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Customer : AllUsers
    {
        public override void Login()
        {
            Customer loggedInCustomer = null;
            int loginAttempts = 0;
            while (loggedInCustomer == null)
            {
                Console.WriteLine("Username:");
                string enteredName = Console.ReadLine();

                // Validate if the entered username exists in CustomerUsers dictionary
                if (CustomerUsers.ContainsValue(enteredName))
                {
                    Console.WriteLine("Password:");
                    string enteredPassword = Console.ReadLine();

                    // Find the key (ID) associated with the entered username
                    int userID = CustomerUsers.FirstOrDefault(x => x.Value == enteredName).Key;

                    // Perform password validation here; replace the placeholder with your logic
                    if (ValidateUserPassword(userID, enteredPassword)) // Example password validation
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome, " + enteredName + "!");
                        // Further actions after successful login can be added here
                        loggedInCustomer = new Customer();
                        loggedInCustomer._IDnumber = userID;
                        loggedInCustomer._username = enteredName;
                        //Lägg till email, birtdate etc
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
            if (loggedInCustomer == null)
            {
                Console.WriteLine("Maximum login attempts reached. Please contact support.");
            }

        }

        // Method to validate admin password
        private bool ValidateUserPassword(int userID, string enteredPassword)
        {
            // Fetch the stored password associated with the userID from  CustomerUsers dictionary
            string storedPassword = string.Empty;

            // Check if the userID exists in the dictionary
            if (CustomerUsers.ContainsKey(userID))
            {
                // Retrieve the stored password corresponding to the userID
                storedPassword = CustomerUsers[userID];
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

        public void LogOut()
        {

        }



    }

}
