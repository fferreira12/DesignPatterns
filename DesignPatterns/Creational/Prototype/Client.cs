using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    class Client
    {

        public static void Main(string[] args)
        {
            /*
            Monster m1 = new Monster(1);
            Monster m5 = new Monster(5);
            Monster m10 = new Monster(10);

            int quantity = 3;

            IClonableMonster[] level1s = new Monster[quantity];
            IClonableMonster[] level5s = new Monster[quantity];
            IClonableMonster[] level10s = new Monster[quantity];

            for (int i = 0; i < quantity; i++)
            {
                level1s[i] = m1.clone();
                level5s[i] = m5.clone();
                level10s[i] = m10.clone();
            }

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine(level1s[i].ToString());
                Console.WriteLine(level5s[i].ToString());
                Console.WriteLine(level10s[i].ToString());
            }
            */

            MonstersRegistry registry = new MonstersRegistry();

            registry.AddMonster("Acolyte", new Monster(1));
            registry.AddMonster("Beholder", new Monster(10));
            registry.AddMonster("Dragon", new Monster(20));

            IClonableMonster acolyte = registry.GetByName("Acolyte");
            IClonableMonster beholder = registry.GetByName("Beholder");
            IClonableMonster dragon = registry.GetByName("Dragon");

            Console.WriteLine(((Monster)acolyte).ToString());
            Console.WriteLine(((Monster)beholder).ToString());
            Console.WriteLine(((Monster)dragon).ToString());

            Console.ReadKey();
        }

    }
}
