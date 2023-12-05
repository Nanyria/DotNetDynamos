using System;
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
            email = Console.ReadLine();
            // Get birthday
            Console.Write("Enter your birthday (YYYY-MM-DD):");
            birthday = Console.ReadLine();

            // Get password from the user
            Console.Write("Password must contain:\n6-12 characters\nAt least one capitol letter\nAt least one digit\nAt least one symbol\nEnter password: ");
            Password = Console.ReadLine();

            _IDnumber = nextCuID++;

            Customer newCustomer = new Customer(_username, _IDnumber, _firstname, _lastname, Password, email, birthday, _accounts); //Lägg till detta i Add metoden sen

            CustomerUsers.Add(_username, newCustomer);

            // Create a new bank account for the user
            //Move to account later?
            Account MainAccount = new Account //name should = AccNumber
            {
                _accountNumber = Account.GenerateAccountNumber(_IDnumber),// Generate a unique account number
                _balance = 0 // Initial balance can be set as needed
            };

            // Assuming you have the user's unique ID (newUserID)
            Account.AddBankAccount(newCustomer); // Add the bank account to the user

            // Display user information
            Console.WriteLine($"User registered!\nUsername: {_username}\nID Number:{nextCuID}\nFirst name: {_firstname}\nLast name: {_lastname}\nEmail: {_email}\nBirthday: {birthday}\nPassword: {Password}");



        }
    }
}
