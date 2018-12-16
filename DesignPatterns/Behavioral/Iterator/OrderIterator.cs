using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Iterator
{
    class OrderIterator<T> : Iterator<T>
    {

        int current = -1;
        ListCollection<T> items;

        public OrderIterator(ListCollection<T> collection)
        {
            items = collection;
        }

        public T GetNext()
        {
            current++;
            if(current >= items.Size())
            {
                return default(T);
            } 
            else
            {
                return items.GetItem(current);
            }
        }

        public bool HasMore()
        {
            return current + 1 < items.Size();
        }
    }
}
