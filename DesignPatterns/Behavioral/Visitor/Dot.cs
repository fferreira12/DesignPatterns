using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    class Dot : IShape
    {
        int x, y;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw()
        {
            Console.WriteLine("Dot at (" + x + ","+y+")");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine("Moving Dot from ("+this.x+","+this.y+" to ("+x+","+y+").");
            this.x = x;
            this.y = y;
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
