using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list;

        public Box()
        {
           this.list = new List<T>();
        }

        public void Add(T element)
        {
            this.list.Add(element);
        }

        public T Remove()
        {
            var element = list[list.Count - 1];
            this.list.RemoveAt(list.Count - 1);

            return element;
        }

        public int Count
        {
            get
            {
                return this.list.Count;
            }
        }
    }
}
