﻿namespace DotNetDynamos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the derived class
            AllUsers userRegistration = new ConsoleUserRegistration();

            // Call the RegisterUser method
            userRegistration.RegisterUser();

        }
    }
}