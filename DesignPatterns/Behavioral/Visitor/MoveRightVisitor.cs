using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    class MoveRightVisitor : Visitor
    {

        int Amount { get; set; }

        public MoveRightVisitor(int amount)
        {
            Amount = amount;
        }

        public void Visit(Dot dot)
        {
            dot.Move(dot.X + Amount, dot.Y);
        }

        public void Visit(Circle circle)
        {
            circle.Move(circle.X + Amount, circle.Y);
        }
    }
}
