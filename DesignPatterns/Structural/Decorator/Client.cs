using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    class Client
    {
        public static void Main(string[] args)
        {
            ValueItem value = new ValueItem(5.0);

            OperationItem op1 = new SumOperation(value, 5.0);
            OperationItem op2 = new SumOperation(op1, 5.0);
            OperationItem op3 = new SumOperation(op2, 5.0);
            OperationItem op4 = new SumOperation(op3, 5.0);
            OperationItem op5 = new MultiplyOperation(op4, 2);
            OperationItem op6 = new MultiplyOperation(op5, 10);

            Console.WriteLine("Total: " + op6.Calculate());
            Console.ReadKey();
        }
    }
}
