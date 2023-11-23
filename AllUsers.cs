using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    // Abstract class for user registration
    public abstract class AllUsers
    {
        // Properties for username and pin code
        public string _username { get; set; }
        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                // Validate pin code when setting
                if (IsBetweenAllowedChar(value))
                {
                    if(ContainsCapitolLetter(value))
                    {
                        _password = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid password. Please use min. one upper-case letter.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid password. Please enter a password between 6-12 characters.");
                }
            }
        }

        // Abstract method to be implemented by derived classes
        public abstract void RegisterUser();

        // Function to validate if the input is a four-digit pin
        protected bool IsBetweenAllowedChar(string input)
        {
            return input.Length >= 6 && input.Length <= 12;
        }

        protected bool ContainsCapitolLetter(string input)
        {
            foreach (char character in input)
            {
                if (char.IsUpper(character))
                {
                    return true;
                }
            }
            return false;
        }
    }

    // Derived class implementing user registration
    public class ConsoleUserRegistration : AllUsers
    {
        public override void RegisterUser()
        {
            Console.WriteLine("Welcome to User Registration!");

            // Get username from the user
            Console.Write("Enter your username: ");
            _username = Console.ReadLine();

            // Get four-digit pin code from the user
            Console.Write("Enter a four-digit pin code: ");
            Password = Console.ReadLine();

            // Display user information
            Console.WriteLine($"User registered!\nUsername: {_username}\nPin Code: {Password}");
        }
    }

}
