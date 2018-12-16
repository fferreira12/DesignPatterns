using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    class Shipping
    {

        IMediator mediator;

        public Shipping(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Ship()
        {
            Console.WriteLine("Item is being shipped");
            mediator.Notify(this);
        }

    }
}
