using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class IKEACoffeTable : CoffeTable
    {

        public IKEACoffeTable()
        {
            Brand = "IKEA";
        }

        public string Brand { get;set; }

        public void Sit()
        {
            Console.WriteLine("Sitting on a " + Brand + " Coffe Table");
        }
    }
}
