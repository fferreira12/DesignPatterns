using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Chain_Of_Responsibility
{
    abstract class BaseHandler : IHandler
    {

        IHandler next;

        public virtual Response Handle(Request request)
        {
            return next.Handle(request);
        }

        public void SetNext(IHandler next)
        {
            this.next = next;
        }
    }
}
