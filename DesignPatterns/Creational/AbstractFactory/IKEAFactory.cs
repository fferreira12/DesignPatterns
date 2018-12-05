using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class IKEAFactory : AbstractFactory
    {
        public override Chair CreateChair()
        {
            return new IKEAChair();
        }

        public override CoffeTable CreateCoffeTable()
        {
            return new IKEACoffeTable();
        }

        public override Desk CreateDesk()
        {
            return new IKEADesk();
        }
    }
}
