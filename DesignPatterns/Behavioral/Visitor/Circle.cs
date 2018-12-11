using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    class Circle : IShape
    {
        int x, y, radius;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public void Draw()
        {
            Console.WriteLine($"Circle at ({X},{Y}). Radius {radius}");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine("Moving Circle from (" + this.x + "," + this.y + " to (" + x + "," + y + ").");
            this.x = x;
            this.y = y;
        }
    }
}
