using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Eventmanagement
{

    internal class Customer
    {
        public static string sqlconnectionStr = @"Data Source=DESKTOP-0GGBKPE\SQLEXPRESS;Initial Catalog=eventmanagement;Integrated Security=True";
        private SqlConnection sqlconnection = new SqlConnection(sqlconnectionStr);
        public void Login()
        {
            Console.WriteLine("enter 1 for menu");
           

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Menu();
            }
            
            

            else
            {
                Console.WriteLine("enter a valid input");
            }


        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\nenter 1 to see the event");
                Console.WriteLine("enter 2 to see equipment");
                Console.WriteLine("enter 3 to see the flower collection");
                Console.WriteLine("enter 4 to see food items");
                Console.WriteLine("enter 5 to see lighting items");
                Console.WriteLine("enter 6 for booking event");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ShowEvents();
                        break;
                    case 2:
                        Showequipment();
                        break;
                    case 3:
                        Showefooditems();
                        break;
                    case 4:
                        Showelight();
                        break;
                    case 5:
                        Showeflower();
                        break;
                    case 6: Bookingdetails(); break;
                    case 7: return;
                    default:
                        Console.WriteLine("enter a valid input");
                        break;

                }
            }
        }
        public DataTable ShowEvents()
        {
            SqlConnection sqlconnection = new SqlConnection(sqlconnectionStr);//connection establishment
            SqlDataAdapter adp = new SqlDataAdapter("select * from Eventdetails", sqlconnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }
        public DataTable Showequipment()
        {
            SqlConnection sqlconnection = new SqlConnection(sqlconnectionStr);//connection establishment
            SqlDataAdapter adp = new SqlDataAdapter("select * from equipment", sqlconnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }
        public DataTable Showefooditems()
        {
            SqlConnection sqlconnection = new SqlConnection(sqlconnectionStr);//connection establishment
            SqlDataAdapter adp = new SqlDataAdapter("select * from Food", sqlconnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }
        public DataTable Showelight()
        {
            SqlConnection sqlconnection = new SqlConnection(sqlconnectionStr);//connection establishment
            SqlDataAdapter adp = new SqlDataAdapter("select * from light", sqlconnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }
        public DataTable Showeflower()
        {
            SqlConnection sqlconnection = new SqlConnection(sqlconnectionStr);//connection establishment
            SqlDataAdapter adp = new SqlDataAdapter("select * from flower", sqlconnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }
        public void Bookingdetails()
        
            
        
        {
            Console.WriteLine("Enter the Event Name ");
            string EventName = Console.ReadLine();
            string sql = "select * from bookingdetails where EventName='" + EventName + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlconnectionStr);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable != null)
            {
                int EventId = Convert.ToInt32(dataTable.Rows[0][0]);
                string Eventstatus = "conform or prnding";
                string bookingdetails = "insert into bookingdetails values('" + EventName + "'," + EventId + ",'" + Eventstatus + "')";
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(bookingdetails, sqlconnectionStr);
                DataTable dataTable1 = new DataTable();
                sqlDataAdapter1.Fill(dataTable1);

            }
        }
    }
}


    


