using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    interface HouseBuilder
    {

        void reset();

        void buildStructure();
        void buildWalls();
        void buildRoof();

        string GetHouse();
    }
}
