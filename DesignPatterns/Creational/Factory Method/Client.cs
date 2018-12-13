using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory_Method
{
    class Client
    {

        public static void Main(string[] args)
        {

            FurnitureFactory factory = new ChairFactory();

            IProduct product = factory.createProduct();

            Console.WriteLine($"Price: {product.getPrice()}");

            factory = new TableFactory();

            product = factory.createProduct();

            Console.WriteLine($"Price: {product.getPrice()}");

            Console.ReadKey();
        }

    }
}
