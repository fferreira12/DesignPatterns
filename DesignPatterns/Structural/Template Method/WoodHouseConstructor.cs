using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Template_Method
{
    class WoodHouseConstructor : HouseConstructor
    {
        public override void BuildFoundation()
        {
            Console.WriteLine("Building wood foundations");
        }

        public override void BuildRoof()
        {
            Console.WriteLine("Building wood roof");
        }

        public override void BuildStructure()
        {
            Console.WriteLine("Building wood structure");
        }
    }
}
