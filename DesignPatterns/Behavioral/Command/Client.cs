using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Command
{
    class Client
    {

        public static void Main(string[] args)
        {

            Invoker invoker = new Invoker();

            Calculator receiver = new Calculator();

            ICommand sumCommand = new SumCommand(receiver, 10, 10);

            invoker.SetCommand(sumCommand);

            invoker.ExecuteCommand();

            ICommand multiplyCommand = new MultiplyCommand(receiver, 10, 10);

            invoker.SetCommand(multiplyCommand);

            invoker.ExecuteCommand();

            Console.ReadKey();
        }

    }
}
