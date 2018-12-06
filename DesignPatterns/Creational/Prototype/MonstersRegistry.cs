using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    class MonstersRegistry
    {

        Dictionary<string, IClonableMonster> monsters = new Dictionary<string, IClonableMonster>();

        public void AddMonster(string name, IClonableMonster monster)
        {
            monsters.Add(name, monster);
        }

        public IClonableMonster GetByName(string name)
        {
            return monsters[name].clone();
        }

    }
}
