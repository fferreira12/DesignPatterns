using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    class Client
    {

        public static void Main(string[] args)
        {

            Caretaker caretaker = new Caretaker();

            caretaker.TypeNewLine("My name is ");
            caretaker.TypeNewLine("Fernando");
            caretaker.TypeNewLine("Rodrigues");
            caretaker.TypeNewLine("Ferreira");

            Console.WriteLine(caretaker.GetText());
            Console.WriteLine();

            caretaker.Undo();
            caretaker.Undo();
            caretaker.Undo();

            Console.WriteLine(caretaker.GetText());
            Console.WriteLine();

            caretaker.Undo();

            Console.WriteLine(caretaker.GetText());
            Console.WriteLine();

            Console.ReadKey();

        }

    }
}
