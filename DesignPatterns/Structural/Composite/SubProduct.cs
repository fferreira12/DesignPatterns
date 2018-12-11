using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    class SubProduct : IProduct
    {
        double _cost;
        List<IProduct> subproducts = new List<IProduct>();

        public SubProduct(double selfCost)
        {
            _cost = selfCost;
        }

        public void AddProduct(IProduct product)
        {
            subproducts.Add(product);
        }

        public void Remove(IProduct product)
        {
            subproducts.Remove(product);
        }

        public double Cost()
        {
            return _cost + subproducts.Select((item) => item.Cost()).Sum();
        }
    }
}
