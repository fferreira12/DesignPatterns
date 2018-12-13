using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweigth
{
    class TreeType
    {

        public string Name { get; set; }
        public string Color { get; set; }
        public string Texture { get; set; }

        public Tree GetTree(int x, int y)
        {
            Tree tree = new Tree()
            {
                X = x,
                Y = y,
                type = this
            };
            return tree;
        }

        public void DrawTree(int x, int y)
        {
            Tree tree = new Tree()
            {
                X = x,
                Y = y,
                type = this
            };
            tree.Draw();
        }

    }
}
