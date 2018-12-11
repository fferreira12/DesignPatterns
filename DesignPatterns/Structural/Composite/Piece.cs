using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    class Piece : IProduct
    {
        double _cost { get; set; }

        public Piece(double cost)
        {
            _cost = cost;
        }

        public double Cost()
        {
            return _cost;
        }
    }
}
