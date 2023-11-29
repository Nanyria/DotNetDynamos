namespace DotNetDynamos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //while (isRunning)
            //{
            //    Admin a1 = new Admin();
            //    Admin.AddUser(1000, "Admin!1");

            //    a1.Login();
            //    a1.Menu();
            //    isRunning = a1.LogOut();
            //}

            bool isRunning = true;

            while (isRunning)
            {
                Customer a1 = new Customer();
                a1.AddUser("Gurra", "Admin!1", 1001);

                a1.Login();
                a1.Menu();
   
            }

        }
    }
}