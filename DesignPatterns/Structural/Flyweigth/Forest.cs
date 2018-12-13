using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweigth
{
    class Forest
    {

        public List<Tree> trees = new List<Tree>();

        public Tree PlantTree(int x, int y, string typeName, string color, string texture)
        {
            TreeType type = TreeFactory.GetTreeType(typeName, color, texture);
            Tree tree = type.GetTree(x, y);
            trees.Add(tree);
            return tree;
        }

    }
}
