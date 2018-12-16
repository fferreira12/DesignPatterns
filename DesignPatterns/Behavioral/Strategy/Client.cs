using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Strategy
{
    class Client
    {

        public static void Main(string[] args)
        {

            Traveler traveler = new Traveler();

            traveler.SetTravelStrategy(new WalkingStrategy());

            traveler.Travel();

            traveler.SetTravelStrategy(new CarStrategy());

            traveler.Travel();

            Console.ReadKey();

        }

    }
}
