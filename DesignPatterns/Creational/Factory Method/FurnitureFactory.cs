using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory_Method
{
    abstract class FurnitureFactory
    {

        public abstract IProduct createProduct();

    }
}
