using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Command
{
    class SumCommand : ICommand
    {

        Calculator receiver;
        double param1, param2;

        public SumCommand(Calculator receiver, double param1, double param2)
        {
            this.receiver = receiver;
            this.param1 = param1;
            this.param2 = param2;
        }

        public void Execute()
        {
            receiver.Sum(param1, param2);
        }
    }
}
