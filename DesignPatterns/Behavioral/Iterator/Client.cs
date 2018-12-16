using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Iterator
{
    class Client
    {

        public static void Main(string[] args)
        {

            ListCollection<string> names = new ListCollection<string>();

            names.AddItem("Fernando");
            names.AddItem("Rodrigues");
            names.AddItem("Ferreira");
            names.AddItem("Fernando");
            names.AddItem("Rodrigues");
            names.AddItem("Ferreira");

            Iterator<string> iterator = names.CreateIterator();

            while (iterator.HasMore())
            {
                Console.WriteLine(iterator.GetNext());
            }

            Console.ReadKey();
        }
    }
}
