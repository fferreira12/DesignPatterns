using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    class SumOperation : OperationItem
    {
        double Value { get; set; }

        public SumOperation(ICalculatable inner, double value) : base(inner)
        {
            Value = value;
        }

        public override double Calculate()
        {
            return Value + inner.Calculate();
        }
    }
}
