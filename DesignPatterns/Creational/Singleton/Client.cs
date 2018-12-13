using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    class Client
    {
        public static void Main(string[] args)
        {
            DatabaseConnection singleton = DatabaseConnection.GetConnection();

            singleton.ToString();

            singleton = DatabaseConnection.GetConnection();
            singleton = DatabaseConnection.GetConnection();
            singleton = DatabaseConnection.GetConnection();
            singleton = DatabaseConnection.GetConnection();

            singleton.ToString();

            Console.WriteLine($"Current Object Number: {singleton.InstanceNumber}");
            Console.WriteLine($"Total number of objects: {DatabaseConnection.TotalInstances}");

            Console.ReadKey();
        }
    }
}
