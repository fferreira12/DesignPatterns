using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    class Client
    {

        public static void Main(string[] args)
        {

            MessagePublisher mp = new MessagePublisher();

            ScreenPrinter sp = new ScreenPrinter();
            FileLogger fl1 = new FileLogger("data1.txt");
            FileLogger fl2 = new FileLogger("data2.txt");

            mp.AddSubscriber(sp);
            mp.AddSubscriber(fl1);
            mp.AddSubscriber(fl2);

            MessageReceiver mr = new MessageReceiver();
            mr.Publisher = mp;

            mr.StartReceiving();

            Console.ReadKey();

        }

    }
}
