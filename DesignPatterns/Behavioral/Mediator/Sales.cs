using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    class Sales
    {

        IMediator mediator;

        public Sales(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Sell()
        {
            Console.WriteLine("Item is being sold");
            mediator.Notify(this);
        }

    }
}
