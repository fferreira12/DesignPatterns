using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public static IKEAFactory IKEA_FACTORY = new IKEAFactory();

        public abstract Desk CreateDesk();
        public abstract Chair CreateChair();
        public abstract CoffeTable CreateCoffeTable();

        public static AbstractFactory GetFactory(Factories factoryType)
        {
            switch(factoryType)
            {
                case Factories.IKEA:
                    return new IKEAFactory();
                case Factories.VICTORIAN:
                    return new VictorianFactory();
                default:
                    return null;
            }
        }
    }
}
