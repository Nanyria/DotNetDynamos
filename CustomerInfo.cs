﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static DotNetDynamos.Account;

namespace DotNetDynamos
{
    internal partial class Customer : AllUsers
    {
        public static Dictionary<string, Customer> CustomerUsers = new Dictionary<string, Customer>(); // _IDnumber, _username
        private static int nextCuID = 1000;     // kolla så att den fortsätter räkna, inte ger ut samma nummer varje gång
        private static int maxLoginAttempts = 3;
        private string _email;
        private DateTime _birthday;
        private List<Account> _accounts;
        public string email
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
        public string birthday
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
        //public Customer() : this("No username provided.", 0000, "No firstname provided.", "No lastname provided.", "No password provided", "no email provided", "0000-00-00") //Lägg till List
        //{

        //}
        public Customer(string username, int IDnumber, string firstname, string lastname, string password, string email, string birthday, List<Account> accounts)
        {
            _username = username;
            _IDnumber = IDnumber;
            _firstname = firstname;
            _lastname = lastname;
            Password = password;
            _email = email;
            this.birthday = birthday;
            _accounts = accounts;

            // Create a new bank account for the user
            //Account MainAccount = new Account
            //{
            //    AccountNumber = Account.GenerateAccountNumber(_IDnumber),// Generate a unique account number
            //    Balance = 0 // Initial balance can be set as needed
            //};
        }


    }
}


