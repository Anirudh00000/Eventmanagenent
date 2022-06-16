using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Eventmanagement
{
    internal class Admin
    {
        public static string sqlconnectionStr = @"Data Source=DESKTOP-0GGBKPE\SQLEXPRESS;Initial Catalog=eventmanagement;Integrated Security=True";
        private SqlConnection sqlconnection = new SqlConnection(sqlconnectionStr);
        public void Homepage()
        {
            while (true)
            {
                Console.WriteLine("enter 1 to InsertEvent");
                Console.WriteLine("enter 2 to Add equipment");
                Console.WriteLine("enter 3 to add Flower");
                Console.WriteLine("enter 4 to add food items");
                Console.WriteLine("enter 5 to add light");
                
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: InsertEvent(); break;
                    case 2: Equipment(); break;
                    case 3: AddFlower(); break;
                    case 4: Addfood(); break;
                    case 5: AddLight(); break;
                    
                    default: Console.WriteLine("enter a valid input"); break;

                }
            }


        }
        public void Login()
        {
            DataTable dt = new DataTable();
            Console.WriteLine("enter Admin name");
            string AdminName = Console.ReadLine();
            Console.WriteLine("enter password");
            string Password = Console.ReadLine();
            SqlConnection sq = new SqlConnection(sqlconnectionStr);
            SqlCommand cmd = new SqlCommand("select * from Adminlogin where AdminName='" + AdminName + "' and Password='" + Password + "'", sq);
            sq.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            sq.Close();

            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("Welcome  " + dt.Rows[0][1]);
                Homepage();
            }
            else
            {
                Console.WriteLine("either username or password is wrong");
                return;
            }
        }
        public string InsertEvent()

        {

            Console.Write("Enter Event Id: ");
            int EventId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter  Event name: ");
            string EventName = Console.ReadLine();



            Console.Write("Enter total cost of the event: ");
            int Cost = Convert.ToInt32(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlconnectionStr);
            string Query = "insert into Eventdetails values(" + EventId + ",'" + EventName + "', '" + Cost + "')";
            SqlCommand cmd = new SqlCommand(Query, sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close

            return "Inserted";

        }
        public string Equipment()

        {

            Console.Write("Enter Equipment Id: ");
            int EquipmentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter  Equipment name: ");
            string EqupmentName = Console.ReadLine();



            Console.Write("Enter total cost of the Equipment: ");
            int EquipmentCost = Convert.ToInt32(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlconnectionStr);
            string Query = "insert into Equipment values(" + EquipmentId + ",'" + EqupmentName + "', '" + EquipmentCost + "')";
            SqlCommand cmd = new SqlCommand(Query, sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close

            return "Inserted";

        }
        public string Addfood()

        {

            Console.Write("Enter food Id: ");
            int FoodId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter  food name: ");
            string FoodName = Console.ReadLine();



            Console.Write("Enter total cost of the food: ");
            int FoodCost = Convert.ToInt32(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlconnectionStr);
            string Query = "insert into Eventdetails values(" + FoodId + ",'" + FoodName + "', '" + FoodCost + "')";
            SqlCommand cmd = new SqlCommand(Query, sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close

            return "Inserted";
            
        }
        public string AddFlower()

        {

            Console.Write("Enter flower Id: ");
            int FlowerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter  flower name: ");
            string FlowerName = Console.ReadLine();



            Console.Write("Enter total cost of the flower: ");
            int FlowerCost = Convert.ToInt32(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlconnectionStr);
            string Query = "insert into Eventdetails values(" + FlowerId + ",'" + FlowerName + "', '" + FlowerCost + "')";
            SqlCommand cmd = new SqlCommand(Query, sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close

            return "Inserted";

        }
        public string AddLight()

        {

            Console.Write("Enter light Id: ");
            int LightId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter  light name: ");
            string LightName = Console.ReadLine();



            Console.Write("Enter total cost of the light: ");
            int LightCost = Convert.ToInt32(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlconnectionStr);
            string Query = "insert into Eventdetails values(" + LightId + ",'" + LightName + "', '" + LightCost + "')";
            SqlCommand cmd = new SqlCommand(Query, sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close

            return "Inserted";

        }
    }
}
