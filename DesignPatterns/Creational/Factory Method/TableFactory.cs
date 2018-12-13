using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory_Method
{
    class TableFactory : FurnitureFactory
    {
        public override IProduct createProduct()
        {
            return new Table();
        }
    }
}
