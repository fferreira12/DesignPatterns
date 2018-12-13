using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    class Client
    {

        public static void Main(string[] args)
        {

            IInternationalSystem adapter = new ImperialToISAdapter();

            Console.WriteLine(adapter.GetMeters(50) + " meters");
            Console.WriteLine(adapter.GetMeters(50) + " meters");
            Console.WriteLine(adapter.GetMeters(50) + " meters");
            Console.WriteLine(adapter.GetMeters(50) + " meters");

            Console.ReadKey();
        }

    }
}
