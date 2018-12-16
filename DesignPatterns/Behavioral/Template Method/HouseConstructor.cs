using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Template_Method
{
    abstract class HouseConstructor
    {

        public void BuildHouse()
        {
            BuildFoundation();
            BuildStructure();
            BuildRoof();
        }

        public abstract void BuildFoundation();
        public abstract void BuildStructure();
        public abstract void BuildRoof();


    }
}
