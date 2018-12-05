using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    class ValueItem : ICalculatable
    {
        double Value { get; set; }

        public ValueItem(double value)
        {
            Value = value;
        }

        public double Calculate()
        {
            return Value;
        }
    }
}
