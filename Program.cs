namespace DotNetDynamos
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Test test = new Test();
            //test.TestTest();
            //while (isRunning)
            //{
            //    Admin a1 = new Admin();
            //    Admin.AddUser(1000, "Admin!1");

            //    a1.Login();
            //    a1.Menu();
            //    isRunning = a1.LogOut();
            //}

            //while (isRunning)
            //{
            //    Customer a1 = new Customer();
            //    a1.AddUser("Gurra", "Admin!1", 1001);

            //    a1.Login();
            //    a1.Menu();

            //}
            //while (isRunning)
            //{
            //    Admin a1 = new Admin("Admin", 5033, "Lars", "Göransson", "Admin!1");
            //    Admin.AdminUsers.Add("Admin", a1);

            //    a1.Login();
            //    a1.Menu();

            //}
            //while (isRunning)
            //{
            //    Customer c1 = new Customer("Kund1", 5013, "Lars", "Göransson", "Kunden!1");
            //    Customer.CustomerUsers.Add("Kund1", c1);

            //    c1.Login();
            //    c1.Menu();

            //}

            bool isRunning = true;

            while (isRunning)
            {

                Customer c1 = new Customer
                (
                    "Kund1",
                    5013,
                    "Lars",
                    "Göransson",
                    "Kunden!1",
                    "lars@goransson.se",
                    "1976-05-03"
                );
                Customer.CustomerUsers.Add("Kund1", c1);

                c1.Login();
                c1.Menu();

            }
        }
    }
}