using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());

            var connection = new SqlConnection("Server=LAPTOP-846MKU7E;Database=adopractice;integrated security = SSPI;");
            connection.Open();

            string sql = "INSERT INTO PERSON VALUES (" + id + ",'" + name + "')";
            Console.WriteLine(sql);
            SqlCommand cmd1 = new SqlCommand("INSERT INTO PERSON VALUES (" + id + ",'" + name + "')", connection);
             cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("Select * from person", connection);
            SqlDataReader sdr2 = cmd2.ExecuteReader();

            while (sdr2.Read())
            {
                Console.WriteLine(sdr2["id"] + " " + sdr2["name"]);
            }

            Console.WriteLine("all done");
            string asjk = Console.ReadLine();

        }
    }
}
