using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class Admin : AllUsers
    {

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

            // Display user information
            Console.WriteLine($"User registered!\nUsername: {_username}\nFirst name: {_firstname}\nLast name: {_lastname}\nPassword: {Password}");
        }
        public override void Login()
        {

        }

        public override void Menu()
        {

        }
    }
}
