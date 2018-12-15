using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Strategy
{
    class Traveler
    {

        ITravelStrategy travelStrategy;

        public void SetTravelStrategy(ITravelStrategy strategy)
        {
            travelStrategy = strategy;
        }

        public void Travel()
        {
            travelStrategy.Travel();
        }


    }
}
