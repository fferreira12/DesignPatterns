using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    class Statistics
    {

        IMediator mediator;

        public Statistics(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void RecordSell()
        {
            Console.WriteLine("Sale stats are being recorded");
            mediator.Notify(this);
        }

    }
}
