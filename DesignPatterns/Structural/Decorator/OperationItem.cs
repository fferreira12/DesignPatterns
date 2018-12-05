using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    abstract class OperationItem : ICalculatable
    {

        protected ICalculatable inner;

        public OperationItem(ICalculatable inner)
        {
            this.inner = inner;
        }

        public abstract double Calculate();

    }
}
