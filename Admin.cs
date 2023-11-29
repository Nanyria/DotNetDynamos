using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal partial class Admin : AllUsers
    {
        public static Dictionary<int, string> AdminUsers = new Dictionary<int, string>();
        private static int nextAdID = 1001;
        private static int maxLoginAttempts = 3;
    }
}
