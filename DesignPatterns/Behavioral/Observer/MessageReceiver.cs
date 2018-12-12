using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    class MessageReceiver
    {

        public MessagePublisher Publisher { get; set; }
        
        public MessageReceiver()
        {
            Publisher = new MessagePublisher();
        }

        public void StartReceiving()
        {
            string text = Console.ReadLine();

            while (text != null && text != "")
            {
                Publisher.NotifySubscribers(text);
                text = Console.ReadLine();
            }

            Console.WriteLine("Reading Messages Finished");
        }
    }
}
