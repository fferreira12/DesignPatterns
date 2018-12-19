using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    class Memento
    {

        string State { get; set; }

        public Memento(string state)
        {
            State = state;
        }

        public string GetState()
        {
            return State;
        }

    }
}
