using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class Customer : User
    {
        public Customer(string username, string password) : base(username, password)
        { 
        }
    }
}
