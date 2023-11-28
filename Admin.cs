using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class Admin : AllUsers
    {
        public static Dictionary<int, string> AdminUsers = new Dictionary<int, string>();
        private static int nextAdID = 1001;

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
            Console.WriteLine("Admin Users:");
            foreach (KeyValuePair<int, string> adminUser in AdminUsers)
            {
                Console.WriteLine($"ID: {adminUser.Key}, Username: {adminUser.Value}");
            }
        }


        public override void Login()
        {
            Admin loggedIn = null;
            int count = 0;
            while (loggedIn == null)
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

                    // Validate the password for the found user ID
                        if (userID != null)
                        {
                            if (count < 3) //Om användaren inte redan använt sina tre inloggningsförsök så - 
                            {
                                Console.WriteLine("Pinkod:");
                                string enteredPin = Console.ReadLine();

                                if (int.TryParse(enteredPin, out int pincode) && userID.pinCode == pincode) //Om pinkoden är i siffror och koden stämmer överens med koden som är inmatad för användaren
                                {
                                    Console.Clear();
                                    Console.WriteLine("Välkommen, " + enteredName + "!");
                                    count = 0; //Antal försök att logga in resettas.
                                    Meny(userID);
                                    LoggedIn = userID;
                                }
                                else
                                {
                                    count++;
                                    Console.Clear();
                                    Console.WriteLine("Du har skrivit fel pinkod. Du har {0} försök kvar.", (3 - count));
                                    if (count >= 3)
                                    {
                                        Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pinkod. Kontakta din bank för att låsa upp ditt konto igen.");
                                        Login();
                                        return null;

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pinkod. Kontakta din bank för att låsa upp ditt konto igen.");
                                Login();
                                return null;

                            }
                            Console.Clear();
                        Console.WriteLine("Welcome, " + enteredName + "!");
                        // Further actions after successful login can be added here
                        loggedIn = // Assign the logged-in user information;
            }
                    else
                    {
                        Console.WriteLine("Incorrect password.");
                    }
                }
                else
                {
                    Console.WriteLine("Username not found.");
                }
            }
            return loggedIn;
        }

        // Method to validate admin password
        private bool ValidateAdminPassword(int userID, string enteredPassword)
        {
            int count = 0;
            if (foundUser != null)
            {
                if (foundUser.count < 3) //Om användaren inte redan använt sina tre inloggningsförsök så - 
                {
                    Console.WriteLine("Pinkod:");
                    string enteredPin = Console.ReadLine();

                    if (int.TryParse(enteredPin, out int pincode) && foundUser.pinCode == pincode) //Om pinkoden är i siffror och koden stämmer överens med koden som är inmatad för användaren
                    {
                        Console.Clear();
                        Console.WriteLine("Välkommen, " + foundUser.userName + "!");
                        foundUser.count = 0; //Antal försök att logga in resettas.
                        Meny(foundUser);
                        LoggedIn = foundUser;
                    }
                    else
                    {
                        foundUser.count++;
                        Console.Clear();
                        Console.WriteLine("Du har skrivit fel pinkod. Du har {0} försök kvar.", (3 - foundUser.count));
                        if (foundUser.count >= 3)
                        {
                            Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pinkod. Kontakta din bank för att låsa upp ditt konto igen.");
                            Login();
                            return null;

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pinkod. Kontakta din bank för att låsa upp ditt konto igen.");
                    Login();
                    return null;

                }
                // Logic to validate password for the given user ID
                // You'll need to implement your own password validation logic here
                // For example, fetching the password associated with the user ID from a secure data source and comparing it with the entered password
                // Return true if the passwords match, else return false
            }
        public override void Login() //Kan vi söka efter id ist för username? Men användaren skrive rin username.
        {
            Console.WriteLine("Välkommen till Awesome Bank!");
            Admin LoggedIn = null;
            while (LoggedIn == null)
            {
                Console.WriteLine("Användarnamn:");
                string enteredName = Console.ReadLine();
                string foundUser = FindUser(enteredName);

                if (foundUser != null)
                {
                    if (foundUser.count < 3) //Om användaren inte redan använt sina tre inloggningsförsök så - 
                    {
                        Console.WriteLine("Pinkod:");
                        string enteredPin = Console.ReadLine();

                        if (int.TryParse(enteredPin, out int pincode) && foundUser.pinCode == pincode) //Om pinkoden är i siffror och koden stämmer överens med koden som är inmatad för användaren
                        {
                            Console.Clear();
                            Console.WriteLine("Välkommen, " + foundUser.userName + "!");
                            foundUser.count = 0; //Antal försök att logga in resettas.
                            Meny(foundUser);
                            LoggedIn = foundUser;
                        }
                        else
                        {
                            foundUser.count++;
                            Console.Clear();
                            Console.WriteLine("Du har skrivit fel pinkod. Du har {0} försök kvar.", (3 - foundUser.count));
                            if (foundUser.count >= 3)
                            {
                                Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pinkod. Kontakta din bank för att låsa upp ditt konto igen.");
                                Login();
                                return null;

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pinkod. Kontakta din bank för att låsa upp ditt konto igen.");
                        Login();
                        return null;

                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Användaren hittades inte.");
                }
            }
            return LoggedIn;
        }



public override void Menu()
        {

        }
    }
}
