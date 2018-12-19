using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    class Caretaker
    {

        Originator originator = new Originator();
        List<Memento> history = new List<Memento>();

        public void TypeNewLine(string line)
        {
            originator.AppendLine(line);
            history.Add(originator.Save());
        }

        public void Undo()
        {
            originator.Restore(history.Last());
            history.RemoveAt(history.Count - 1);
        }

        public string GetText()
        {
            return originator.GetState();
        }
    }
}
