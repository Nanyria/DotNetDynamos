using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    public abstract class AllUsers
    {
        // Properties for username password with conditions for password
        //Fixa så det inte kan vara null
        public string _username { get; set; }
        public int _IDnumber { get;  set; }
        public string _firstname { get; set; }
        public string _lastname { get; set; }
        //public bool _ifadmin;
        

        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                // Validate password, check if all conditions are filled.
                if (IsBetweenAllowedChar(value))
                {
                    if(ContainsCapitolLetter(value))
                    {
                        if(ContainsDigit(value))
                        {
                           if(ContainsSymbol(value))
                            {
                                _password = value;
                            }
                           else
                            {
                                Console.WriteLine("Invalid password. Must contain at least one symbol.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid password. Must contain at least one digit");
                        }
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

        // Function to validate if the input is between 6-12 char.
        protected bool IsBetweenAllowedChar(string input)
        {
            return input.Length >= 6 && input.Length <= 12;
        }

        // Function to validate if the input contains at least one capitol letter.
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

        // Function to validate if the input contains at least one digit.
        protected bool ContainsDigit(string input)
        {
            foreach (char character in input)
            {
                if (char.IsDigit(character))
                {
                    return true;
                }
            }
            return false;
        }

        // Function to validate if the input contains at least one symbol.
        protected bool ContainsSymbol(string input)
        {
            foreach (char character in input)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return true;
                }
            }
            return false;
        }

        // Abstract method to be implemented by derived classes.
        public abstract void RegisterUser();

        public abstract void Login();
        public abstract void Menu();
        public abstract void UserList();
         
    }




}
