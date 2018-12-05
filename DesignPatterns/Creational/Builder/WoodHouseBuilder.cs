using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    class WoodHouseBuilder : HouseBuilder
    {

        string Description { get; set; }

        public WoodHouseBuilder()
        {
            reset();
        }

        public void buildRoof()
        {
            Description = Description + ", wooden roof";
        }

        public void buildStructure()
        {
            Description = Description + ", wooden structure";
        }

        public void buildWalls()
        {
            Description = Description + ", wooden walls";
        }

        public void reset()
        {
            Description = "Wood House";
        }

        public string GetHouse()
        {
            return Description + ".";
        }
    }
}
