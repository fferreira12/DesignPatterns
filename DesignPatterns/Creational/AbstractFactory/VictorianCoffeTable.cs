using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class VictorianCoffeeTable : CoffeTable
    {
        public VictorianCoffeeTable()
        {
            Brand = "Victorian";
        }

        public string Brand { get; set; }

        public void Sit()
        {
            Console.WriteLine("Sitting on a " + Brand + " chair");
        }
    }
}
