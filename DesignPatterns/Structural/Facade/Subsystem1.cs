using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    class Subsystem1
    {

        public void Operation1()
        {
            Console.WriteLine("Subsystem 1 performing operation 1");
        }

        public void Operation2()
        {
            Console.WriteLine("Subsystem 1 performing operation 2");
        }

    }
}
