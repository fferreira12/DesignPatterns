using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweigth
{
    class TreeFactory
    {

        static List<TreeType> treeTypes = new List<TreeType>();
        public static int NumberOfTreeTypes()
        {
            return treeTypes.Count();
        }

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            TreeType found = treeTypes.Find((t) =>
            {
                return t.Name == name && t.Color == color && t.Texture == texture;
            });

            if(found != null)
            {
                return found;
            }
            else
            {
                TreeType newType = new TreeType()
                {
                    Name = name,
                    Color = color,
                    Texture = texture
                };
                treeTypes.Add(newType);
                return newType;
            }
        }

    }
}
