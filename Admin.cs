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
        public static Dictionary<string, string> AdminUsers = new Dictionary<string, string>();
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
            nextAdID++;

            AdminUsers.Add(Password, _username);

            // Display user information
            Console.WriteLine($"User registered!\nUsername: {_username}\nID Number:{_IDnumber}\nFirst name: {_firstname}\nLast name: {_lastname}\nPassword: {Password}");
        }
        public static void RegisterCustomer()
        {
            Customer customer = new Customer();
            customer.RegisterUser();

        }
        public override void UserList() //Ändra om så den läser ut id
        {
            foreach (KeyValuePair<string, string> item in AdminUsers)
            {
                Console.WriteLine("ID: {0}, \nUsername: {1}", item., item.Value);
            }
        }
        public override void Login()
        {
            Console.WriteLine("Välkommen till Awesome Bank!");
            Admin LoggedIn = null;
            while (LoggedIn == null)
            {
                Console.WriteLine("Användarnamn:");
                string enteredName = Console.ReadLine();
                Admin foundUser = AdminUsers.FirstOrDefault(u => u.string == enteredName); //Söker efter användaren i listan AllUsers. 
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
