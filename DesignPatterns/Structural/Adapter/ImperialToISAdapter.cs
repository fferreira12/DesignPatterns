using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    class ImperialToISAdapter : IInternationalSystem
    {
        ImperialRandomDistances imperial = new ImperialRandomDistances();

        public double GetMeters(double max)
        {
            return imperial.GetRandomFeet(max * 3.28) * 0.3048;
        }

    }
}
