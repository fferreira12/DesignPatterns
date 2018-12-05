using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        public static void Main(string[] args)
        {
            AbstractFactory factory = AbstractFactory.GetFactory(Factories.IKEA);

            Chair chair = factory.CreateChair();

            chair.Sit();

            factory = AbstractFactory.GetFactory(Factories.VICTORIAN);

            chair = factory.CreateChair();

            chair.Sit();

            Console.ReadKey();
        }
    }
}
