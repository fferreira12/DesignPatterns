using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    class Client
    {

        public static void Main(string[] args)
        {

            Subsystem1 sb1 = new Subsystem1();
            Subsystem2 sb2 = new Subsystem2();

            Facade facade = new Facade(sb1, sb2);

            facade.DoSimplified();

            Console.ReadKey();

        }
    }
}
