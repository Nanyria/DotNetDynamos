using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class Account
    {
        public string AccountHolder {  get; set; }
        public decimal Balance { get; set; }
        public Account(string accountholder, decimal balance)
        {
            AccountHolder = accountholder;
            Balance = balance;
        }
    }
}
