using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory_Method
{
    class Table : IProduct
    {
        public double getPrice()
        {
            return 150.0;
        }
    }
}
