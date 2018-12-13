using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweigth
{
    class Client
    {
        public static void Main(string[] args)
        {
            //TreeFactory fac = new TreeFactory();
            TreeType type = TreeFactory.GetTreeType("Common Tree", "Green", "Woodish");

            Forest forest = new Forest();

            for (int i = 0; i < 100; i++)
            {
                forest.PlantTree(i, i + 10, "Common Tree", "Green", "Woodish");
            }

            foreach (Tree tree in forest.trees)
            {
                tree.Draw();
            }

            Console.WriteLine($"Number of Trees: {forest.trees.Count}");
            Console.WriteLine($"Number of Tree Types: {TreeFactory.NumberOfTreeTypes()}");

            Console.ReadKey();
        }
    }
}
