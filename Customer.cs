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
            return email.Contains("@");
        }
       

        private DateTime _birthday;
       
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                if (IsValidDay(value))
                {
                    _birthday = value;
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please enter a valid date.");
                }
            }
        }
       protected bool IsValidDay(DateTime day)
       {
            return true;
     
       }


        public int Idnumber { get; set; }


        public override void RegisterUser()
        {
            Console.WriteLine("Welcome to User Registration!");

            // Get username emila address
            Console.Write("Enter your email address: ");
            Email = Console.ReadLine();
            // Get birthday
            Console.Write("Enter your birthday (YYYY-MM-DD):");
            if(DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
            {
                Birthday = birthday;
            }


            //DateTime birthday;
            //while (true)
            //{
            //    Console.Write("Enter your birthday (YYYY-MM-DD):");

            //    if (DateTime.TryParse(Console.ReadLine(), out birthday))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid date format. Please enter a valid date.");
            //    }
            //}

            Console.Write("Enter your ID-number: ");
                int userID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{_email}, {Birthday}, ");

            }

        }
    }

