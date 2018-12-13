using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    class Facade
    {
        Subsystem1 subsystem1;
        Subsystem2 subsystem2;

        public Facade(Subsystem1 sub1, Subsystem2 sub2)
        {
            subsystem1 = sub1;
            subsystem2 = sub2;
        }

        public void DoSimplified()
        {
            Console.WriteLine("Starting Initialization");
            Console.WriteLine("Starting Subsystem 1");
            subsystem1.Operation1();
            subsystem1.Operation2();
            Console.WriteLine("Starting Subsystem 2");
            subsystem2.Operation1();
            subsystem2.Operation2();
            Console.WriteLine("Finished Initialization");
        }
    }
}
