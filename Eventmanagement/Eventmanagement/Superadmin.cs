using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Eventmanagement
{
    internal class Superadmin
    {
        public static string sqlconnectionStr = @"Data Source=DESKTOP-0GGBKPE\SQLEXPRESS;Initial Catalog=eventmanagement;Integrated Security=True";

        private SqlConnection sqlconnection = new SqlConnection(sqlconnectionStr);
    
        public void Loginsuperadmin()
        {
            Console.WriteLine("enter 1 for login");
            Console.WriteLine("enter 2 for registration");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Addadmin();
            }
            
            else
            {
                Console.WriteLine("enter a valid input");
            }
        }
        

        public string Addadmin()

        
            {

                Console.Write("Enter Admin Id: ");
                int AdminId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter  Admin name: ");
                string AdminName = Console.ReadLine();

                Console.Write("Enter admin type ");
                string AdminType = Console.ReadLine();

                SqlConnection sqlConnection = new SqlConnection(sqlconnectionStr);
                string Query = "insert into Admindetails values(" + AdminId + ",'" + AdminName + "','" + AdminType + "')";
                SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                sqlConnection.Open();//connection state is open
                cmd.ExecuteNonQuery();//execute my sql commands 1
                sqlConnection.Close(); //connection state is close

                return "insert secess";
            }
            }
    }

