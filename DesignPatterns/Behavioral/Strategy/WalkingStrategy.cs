using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Strategy
{
    class WalkingStrategy : ITravelStrategy
    {
        public void Travel()
        {
            Console.WriteLine("Walking to destination");
        }
    }
}
