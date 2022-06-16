using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventmanagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                Superadmin supersadmin = new Superadmin();
                Admin admins = new Admin();
                Customer customer = new Customer();
                while (true)
                {
                    Console.WriteLine("for super admin press 1");
                    Console.WriteLine("for  admin press 2");
                    Console.WriteLine("for customer  press 3");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        supersadmin.Loginsuperadmin();
                    }
                    else if (choice == 2)
                    {
                        admins.Login();
                    }
                    else if (choice == 3)
                    {
                     customer.Login();
                    }
                    else
                    {
                        Console.WriteLine("enter a valid input");
                    }

                }
                 //ShowEvents showevent = new ShowEvents();
                //addevent.InsertEvent();
                //Customer customer = new Customer();
                //customer.SelectEvent();



            }
        }
    }
}
