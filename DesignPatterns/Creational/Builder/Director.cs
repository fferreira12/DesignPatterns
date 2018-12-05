using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    class Director
    {

        HouseBuilder builder;

        public Director(HouseBuilder builder)
        {
            ChangeBuilder(builder);
        }

        public void ChangeBuilder(HouseBuilder builder)
        {
            this.builder = builder;
        }

        public string BuildAndReturn()
        {
            builder.reset();
            builder.buildStructure();
            builder.buildWalls();
            builder.buildRoof();
            return builder.GetHouse();
        }

        public string SimpleHouse()
        {
            builder.reset();
            return builder.GetHouse();
        }
    }
}
