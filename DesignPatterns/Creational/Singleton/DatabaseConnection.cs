using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance = null;
        public static int TotalInstances { get; set; }

        public int InstanceNumber { get; }

        private DatabaseConnection()
        {
            InstanceNumber = TotalInstances;
            TotalInstances++;
        }

        public static DatabaseConnection GetConnection()
        {
            Console.WriteLine("Get Connection Called");
            if (instance == null)
            {
                instance = new DatabaseConnection();
            }
            return instance;
        }

        public override string ToString()
        {
            return $"Instance {InstanceNumber} being called";
        }
    }
}
