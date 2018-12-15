using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Chain_Of_Responsibility
{
    interface IHandler
    {

        void SetNext(IHandler next);
        Response Handle(Request request);

    }
}
