using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    class Client
    {

        public static void Main(string[] args)
        {

            SalesMediator mediator = new SalesMediator();

            mediator.Sales.Sell();

            Console.ReadKey();

        }

    }
}
