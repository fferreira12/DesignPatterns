using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    class Client
    {

        public static void Main(string[] args)
        {

            IService proxy = new LoggerProxy();

            for (int i = 0; i < 20; i++)
            {
                proxy.GetData();
            }

            Console.ReadKey();

        }
    }
}
