using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    class Client
    {

        public static void Main(string[] args)
        {

            IProduct p1 = new Piece(2.0);
            IProduct p2 = new Piece(3.0);

            SubProduct p3 = new SubProduct(1.0);
            p3.AddProduct(p1);
            p3.AddProduct(p2);
            p3.AddProduct(new Piece(1.0));
            p3.AddProduct(new Piece(2.0));
            p3.AddProduct(new Piece(3.0));

            SubProduct p4 = new SubProduct(1.0);
            p4.AddProduct(new Piece(1.0));
            p4.AddProduct(new Piece(2.0));
            p4.AddProduct(p3);
            p4.AddProduct(p3);
            p4.AddProduct(p3);
            p4.AddProduct(p3);

            IProduct finalProduct = p4;
            Console.WriteLine(finalProduct.Cost());

            Console.ReadKey();

        }

    }
}
