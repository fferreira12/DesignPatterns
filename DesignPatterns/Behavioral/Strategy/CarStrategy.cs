using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Strategy
{
    class CarStrategy : ITravelStrategy
    {
        public void Travel()
        {
            Console.WriteLine("Going by car to destination");
        }
    }
}
