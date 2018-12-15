using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Iterator
{
    class ListCollection<T> : IterableCollection<T>
    {

        List<T> items;

        public ListCollection()
        {
            items = new List<T>();
        }

        public Iterator<T> CreateIterator()
        {
            return new OrderIterator<T>(this);
        }

        public T GetItem(int index)
        {
            return items[index];
        }

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public int Size()
        {
            return items.Count;
        }

    }
}
