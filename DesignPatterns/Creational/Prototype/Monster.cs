using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    class Monster : IClonableMonster
    {
        int level;
        int posX;
        int posY;
        int attack;
        int defense;
        int life;

        static Random rnd = new Random();

        public Monster(int level)
        {
            this.level = level;
            posX = (int) Math.Round(rnd.NextDouble() * 100);
            posY = (int) Math.Round(rnd.NextDouble() * 100);
            attack = level * rnd.Next(1, 6);
            defense = level * rnd.Next(1, 6);
            life = level * rnd.Next(1, 21);
        }

        public IClonableMonster clone()
        {
            Monster m = new Monster(level);
            m.posX = posX;
            m.posY = posY;
            m.attack = attack;
            m.defense = defense;
            m.life = life;
            return m;
        }

        public override string ToString()
        {
            return "Lvl " + level + " monster\n" +
                "Position " + "(" + posX + ", " + posY + ")\n" +
                "Attack: " + attack + " Defense: " + defense + "\n" +
                "Life: " + life + "\n";
        }

    }
}
