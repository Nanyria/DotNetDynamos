﻿namespace DotNetDynamos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Admin a1 = new Admin();
            Admin.AddUser(1000, "Admin!1");

            a1.Login();
            a1.Menu();



        }
    }
}