using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweigth
{
    class Tree
    {

        public int X { get; set; }
        public int Y { get; set; }
        public TreeType type { get; set; }

        public void Draw()
        {
            Console.WriteLine($"Drawing {type.Name} at ({X},{Y})");
        }

    }
}
