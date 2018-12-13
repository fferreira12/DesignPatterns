using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    class ImperialRandomDistances
    {
        static Random random = new Random();

        public double GetRandomFeet(double max)
        {
            return random.NextDouble() * max;
        }

    }
}
