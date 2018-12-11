using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    interface IShape
    {

        void Move(int x, int y);
        void Draw();
        void Accept(Visitor visitor);

    }
}
