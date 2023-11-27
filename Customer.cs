using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class Customer : AllUsers
    {
        private string _email;
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
        private DateTime _birthday;
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
        public int IDnumber { get; set; } // Ska vi tilldela 

        public override void RegisterUser()
        {
            Console.WriteLine("Welcome to User Registration!");
            // Get username emila address
            Console.Write("Enter your email address: ");
            Email = Console.ReadLine();
            // Get birthday
            Console.Write("Enter your birthday (YYYY-MM-DD):");
            Birthday = Console.ReadLine();
            // Get ID
            Console.Write("Enter your ID-number: ");
            IDnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Email: {_email}, Birthday: {Birthday},ID: {IDnumber} ");
        }
    }
}


