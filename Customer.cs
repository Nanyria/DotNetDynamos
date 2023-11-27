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
                    Console.WriteLine("Invalid mail address.");
                }

            }
        }
        protected bool IsValidEmail(string email)
        {
            
        }

        public DateTime Birthday { get; set; }
        public int Idnumber { get; set; }

        public override void RegisterUser()
        {

        }

    }
}
