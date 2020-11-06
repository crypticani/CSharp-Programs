using System;
using MySqlConnector;

namespace test
{
    class Program
    {
        public static void Main(string[] args)
        {
            string connectionString;
            MySqlConnection conn;
            connectionString = @"Data Source=localhost;Initial Catalog=test;User ID=myuser;Password=password";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            Console.WriteLine("Connected to Database!");
            string query = "select * from student";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            Console.WriteLine(dataReader.GetName(0)+"    "+dataReader.GetName(1)+"    "+dataReader.GetName(2));
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader.GetValue(0)+" "+ dataReader.GetValue(1)+" "+dataReader.GetValue(2));
            }
            conn.Close();
        }
    }
}
