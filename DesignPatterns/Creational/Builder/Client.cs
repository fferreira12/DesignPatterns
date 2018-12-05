using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    class Client
    {
        public static void Main(string[] args)
        {
            HouseBuilder builder = new WoodHouseBuilder();

            Director director = new Director(builder);

            Console.WriteLine(director.BuildAndReturn());

            builder = new ConcreteHouseBuilder();

            director.ChangeBuilder(builder);

            Console.WriteLine(director.BuildAndReturn());

            Console.ReadKey();
        }
    }
}
