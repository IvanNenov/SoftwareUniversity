using System;
using System.Collections.Generic;
using System.Text;

namespace ListIterator
{
    public class ListyIterator<T>
    {
        private List<T> elements;
        private int index;

        public ListyIterator(params T[] elements)
        {
            this.elements = new List<T>(elements);
        }

        public bool Move()
        {
            if (index <elements.Count -1)
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return index + 1 < elements.Count;
        }

        public T Print()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException($"Invalid Operation!");
            }

            return elements[index];
        }
    }
}
