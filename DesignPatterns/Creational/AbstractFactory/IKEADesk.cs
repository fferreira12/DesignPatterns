using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class IKEADesk : Desk
    {

        public IKEADesk()
        {
            Brand = "IKEA";
        }

        public string Brand { get; set; }

        public void Sit()
        {
            Console.WriteLine("Sitting on a " + Brand + " Desk");
        }
    }
}
