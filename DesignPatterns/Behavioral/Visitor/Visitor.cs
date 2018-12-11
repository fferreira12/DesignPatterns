using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    interface Visitor
    {

        void Visit(Dot dot);
        void Visit(Circle circle);

    }
}
