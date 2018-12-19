using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    class Originator
    {

        string State = "";

        public Memento Save()
        {
            return new Memento(State);
        }

        public void Restore(Memento memento)
        {
            State = memento.GetState();
        }

        public void AppendLine(string line)
        {
            State = State + "\n" + line;
        }

        public string GetState()
        {
            return State;
        }
    }
}
