﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Customer : AllUsers
    {
        //Check to see if we should register users only in Admin or if users should be able to register themselves
        public override void RegisterUser()
        {

            //Lägg till ett acc för nyreg kund

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

            CustomerUsers.Add(_IDnumber, _username);

            // Create a new bank account for the user
            Account newAccount = new Account
            {
                AccountNumber = Account.GenerateAccountNumber(_IDnumber),// Generate a unique account number
                Balance = 0 // Initial balance can be set as needed
            };

            // Assuming you have the user's unique ID (newUserID)
            Account.AddBankAccount(_IDnumber, newAccount); // Add the bank account to the user

            // Display user information
            Console.WriteLine($"User registered!\nUsername: {_username}\nID Number:{nextCuID}\nFirst name: {_firstname}\nLast name: {_lastname}\nEmail: {_email}\nBirthday: {Birthday}\nPassword: {Password}");



        }
    }
}
