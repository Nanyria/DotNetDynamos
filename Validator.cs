using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamos
{
    internal class Validator
    {
        public static int GetValidInt()
        {
            int value;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out value))
                    Console.WriteLine("Invalid input. Please enter an integer.");
                else
                    return value;
            }
        }
        public static int GetValidIntOrGoToMenu() // This goes back to meny if the user pressed enter.
        {
            Customer cus = null;
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                cus.Menu();
                return 0;
            }
            else
            {
                if (int.TryParse(input, out int number))
                    return number;
                else
                {
                    Console.WriteLine("Invalid input. Please enter integer.");
                    return GetValidIntOrGoToMenu();
                }
            }
        }
        public static string GetValidString()
        {
            string value = String.Empty;
            while (String.IsNullOrEmpty(value))
            {
                value = Console.ReadLine();
                if (String.IsNullOrEmpty(value))
                    Console.WriteLine("Please insert");
            }
            return value;
        }
        public static decimal GetValidDecimal()
        {
            decimal money;
            while (true)
            {
                if (!decimal.TryParse(Console.ReadLine(), out money))
                    Console.WriteLine("Invalid input. Please enter an integer.");
                else
                    return money;
            }
        }
    }
}
