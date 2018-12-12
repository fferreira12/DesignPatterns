using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    class ScreenPrinter : ISubscriber
    {
        public void Update(string message)
        {
            Console.WriteLine(message);
        }
    }
}
