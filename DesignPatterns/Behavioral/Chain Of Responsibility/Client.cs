using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Chain_Of_Responsibility
{
    class Client
    {

        public static void Main(string[] args)
        {

            IHandler handler1 = new LoggerHandler();
            IHandler handler2 = new AuthHandler();
            IHandler handler3 = new PageHandler();

            handler1.SetNext(handler2);
            handler2.SetNext(handler3);

            handler1.Handle(new Request()
            {
                AUTHToken = "1234",
                RequestURL = "/main"
            });

            Console.ReadKey();
        }
    }
}
