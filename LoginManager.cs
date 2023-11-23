using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class LoginManager
    {
        
        List<User> users = new List<User>()         // Test 
        {
            new Customer("Asuka", "1234"),
            new Admin("Philip", "1234"),
            new Customer("Stefan", "4567"),
            new Customer("Nathalee", "3456"),
            new Admin("Vincent", "2345"),
        };
        
       public void Hej()
        {

        }

    }

}
