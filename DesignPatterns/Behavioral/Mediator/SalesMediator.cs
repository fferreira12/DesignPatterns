using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    class SalesMediator : IMediator
    {
        public Sales Sales { get; set; }
        Shipping shipping;
        Statistics stats;

        public SalesMediator()
        {
            Sales = new Sales(this);
            shipping = new Shipping(this); ;
            stats = new Statistics(this);
        }

        public void Notify(object sender)
        {
            if(sender is Sales)
            {
                Console.WriteLine("Sale has been made. Proceeding shipping.");
                shipping.Ship();
            } 
            else if(sender is Shipping)
            {
                Console.WriteLine("Shipping has been made. Proceeding stat recording.");
                stats.RecordSell();
            }
            else if(sender is Statistics)
            {
                Console.WriteLine("Stats has been recorded.");

            }
        }
    }
}
