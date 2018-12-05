using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class VictorianFactory : AbstractFactory
    {
        public override Chair CreateChair()
        {
            return new VictorianChair();
        }

        public override CoffeTable CreateCoffeTable()
        {
            return new VictorianCoffeeTable();
        }

        public override Desk CreateDesk()
        {
            return new VictorianDesk();
        }
    }
}

