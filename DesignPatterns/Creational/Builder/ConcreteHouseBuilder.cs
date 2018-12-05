using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    class ConcreteHouseBuilder : HouseBuilder
    {

        string Description { get; set; }

        public ConcreteHouseBuilder()
        {
            reset();
        }

        public void buildRoof()
        {
            Description = Description + ", concrete roof";
        }

        public void buildStructure()
        {
            Description = Description + ", concrete structure";
        }

        public void buildWalls()
        {
            Description = Description + ", concrete walls";
        }

        public void reset()
        {
            Description = "Concrete House";
        }

        public string GetHouse()
        {
            return Description + ".";
        }
    }
}
