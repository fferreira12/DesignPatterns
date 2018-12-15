using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Iterator
{
    interface IterableCollection<T>
    {

        Iterator<T> CreateIterator();

    }
}
