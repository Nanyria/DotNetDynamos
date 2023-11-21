using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    // Abstract class for user registration
    public abstract class UserRegistration
    {
        // Properties for username and pin code
        public string Username { get; set; }
        private string _pinCode;

        public string PinCode
        {
            get => _pinCode;
            set
            {
                // Validate pin code when setting
                if (IsFourDigitPin(value))
                {
                    pinCode = value;
                }
                else
                {
                    Console.WriteLine("Invalid pin code. Please enter a four-digit pin code.");
                }
            }
        }

        // Abstract method to be implemented by derived classes
        public abstract void RegisterUser();

        // Function to validate if the input is a four-digit pin
        protected bool IsFourDigitPin(string input)
        {
            return input.Length == 4 && int.TryParse(input, out );
        }
    }

    // Derived class implementing user registration
    public class ConsoleUserRegistration : UserRegistration
    {
        public override void RegisterUser()
        {
            Console.WriteLine("Welcome to User Registration!");

            // Get username from the user
            Console.Write("Enter your username: ");
            Username = Console.ReadLine();

            // Get four-digit pin code from the user
            Console.Write("Enter a four-digit pin code: ");
            PinCode = Console.ReadLine();

            // Display user information
            Console.WriteLine($"User registered!\nUsername: {Username}\nPin Code: {PinCode}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of the derived class
            UserRegistration userRegistration = new ConsoleUserRegistration();

            // Call the RegisterUser method
            userRegistration.RegisterUser();
        }
    }
}
