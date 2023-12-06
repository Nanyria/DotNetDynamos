namespace DotNetDynamos
{
    internal partial class Customer : AllUsers
    {
        public override AllUsers Login()
        {
            Customer loggedInCustomer = null;
            int loginAttempts = 0;
            int maxLoginAttempts = 3; // Assuming a maximum of 3 login attempts

            while (loginAttempts < maxLoginAttempts && loggedInCustomer == null)
            {
                Console.WriteLine("Username:");
                string enteredName = Console.ReadLine();

                // Validate if the entered username exists in CustomerUsers dictionary
                if (CustomerUsers.ContainsKey(enteredName))
                {
                    Console.WriteLine("Password:");
                    string enteredPassword = Console.ReadLine();

                    // Perform password validation here
                    if (ValidateCustomerPassword(enteredName, enteredPassword)) // Example password validation
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome, " + enteredName + "!");
                        // Further actions after successful login can be added here
                        loggedInCustomer = CustomerUsers[enteredName];
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

            return loggedInCustomer;

        }

        // Method to validate admin password
        private bool ValidateCustomerPassword(string enteredName, string enteredPassword)
        {

            // Check if the userID exists in the dictionary
            if (CustomerUsers.ContainsKey(enteredName))
            {
                // Retrieve the stored password corresponding to the username
                Customer storedCustomer = CustomerUsers[enteredName];

                return enteredPassword == storedCustomer.Password;
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
                    Console.WriteLine("You have been logged out.");
                    //Return loggedincustomer från Loginmetod kanske, så kan vi använda loggedInCustomer == null.
                    Login(); // Log Out  
                    break;
                case 2:
                    Console.WriteLine("You will now be logged out and the program will exit.");
                    //Return loggedincustomer från Loginmetod kanske, så kan vi använda loggedInCustomer == null.
                    Environment.Exit(0); // Exit the program
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again."); // Stay in the loop
                    break;
            }
        }
    }
}
