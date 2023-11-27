﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class Customer : AllUsers
    {
        public static Dictionary<int, string> CustomerUsers = new Dictionary<int, string>();
        private static int nextCuID = 1000;
        private string _email;
        private DateTime _birthday;
        public string Email
        {
            get => _email;
            set
            {
                if (IsValidEmail(value))
                {
                    _email = value;
                }
                else
                {
                    Console.WriteLine("Invalid email format. Please enter a valid email address.");
                }
            }
        }
        protected static bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
        
        //Fix so that user has to enter bithdate until correct bd has been entered
        public string Birthday
        {
            get => _birthday.ToString();
            set
            {
                if (DateTime.TryParse(value, out DateTime date))
                {
                    _birthday = date;
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please enter a valid date.");
                }
            }
        }

        //Check to see if we should register users only in Admin or if users should be able to register themselves
        public override void RegisterUser()
        {

            Console.WriteLine("Welcome to User Registration!");

            // Get username from the user
            Console.Write("Enter user username: ");
            _username = Console.ReadLine();

            // Get first name from the user
            Console.Write("Enter user first name: ");
            _firstname = Console.ReadLine();

            //Get last name from the user
            Console.Write("Enter user last name: ");
            _lastname = Console.ReadLine();

            Console.Write("Enter your email address: ");
            Email = Console.ReadLine();
            // Get birthday
            Console.Write("Enter your birthday (YYYY-MM-DD):");
            Birthday = Console.ReadLine();

            // Get password from the user
            Console.Write("Password must contain:\n6-12 characters\nAt least one capitol letter\nAt least one digit\nAt least one symbol\nEnter password: ");
            Password = Console.ReadLine();

            _IDnumber = nextCuID++;
            
            CustomerUsers.Add(nextCuID, _username);

            // Display user information
            Console.WriteLine($"User registered!\nUsername: {_username}\nID Number:{nextCuID}\nFirst name: {_firstname}\nLast name: {_lastname}\nEmail: {_email}\nBirthday: {Birthday}\nPassword: {Password}");

            //Console.WriteLine("Welcome to User Registration!");
            //// Get username emila address

            //// Get ID
            //Console.Write("Enter your ID-number: ");
            //IDnumber = Convert.ToInt32(Console.ReadLine());

        }
        public override void Login()
        {
           
        }
        public override void Menu()
        {
            
        }
        public override void UserList()
        {
            foreach (KeyValuePair<int, string> item in CustomerUsers)
            {
                Console.WriteLine("ID: {0}, \nUsername: {1}", item.Key, item.Value);
            }

        }
    }
}


