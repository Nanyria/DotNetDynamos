namespace DotNetDynamos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            
            bool isRunning = true;

            //while (isRunning)
            //{
            //    Admin a1 = new Admin();
            //    Admin.AddUser(1000, "Admin!1");

            //    a1.Login();
            //    a1.Menu();
            //    isRunning = a1.LogOut();
            //}

           

            while (isRunning)
            {
                Customer a1 = new Customer();
                Customer.AddUser(1000, "Admin!1");

                a1.Login();
                a1.Menu();
                
            }

        }
    }
}