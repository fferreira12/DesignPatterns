using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Template_Method
{
    class Client
    {

        public static void Main(string[] args)
        {

            HouseConstructor constructor = new WoodHouseConstructor();

            constructor.BuildHouse();

            constructor = new SteelHouseConstructor();

            constructor.BuildHouse();

            Console.ReadKey();
        }
    }
}
