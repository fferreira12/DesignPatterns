using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Template_Method
{
    class SteelHouseConstructor : HouseConstructor
    {
        public override void BuildFoundation()
        {
            Console.WriteLine("Building steel foundations");
        }

        public override void BuildRoof()
        {
            Console.WriteLine("Building steel roof");
        }

        public override void BuildStructure()
        {
            Console.WriteLine("Building steel structure");
        }
    }
}
