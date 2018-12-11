using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    class Client
    {

        public static void Main(string[] args)
        {

            IShape[] shapes = new IShape[] {
                new Dot(0,0),
                new Circle(0,0,10)
            };

            Visitor moveRightVisitor = new MoveRightVisitor(10);

            //before
            Console.WriteLine("Before: ");
            foreach (IShape shape in shapes)
            {
                shape.Draw();
            }

            Console.WriteLine("Visiting all...");
            foreach (IShape shape in shapes)
            {
                shape.Accept(moveRightVisitor);
            }

            //after
            Console.WriteLine("After: ");
            foreach (IShape shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadKey();
        }

    }
}
