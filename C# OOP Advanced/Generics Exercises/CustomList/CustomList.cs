using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomList
{
    public class CustomList<T> : List<T>
                  where T : IComparable<T>
    {
        private List<T> list;

        public CustomList()
        {
            this.list = new List<T>();
        }

        public void Add(T element)
        {
            this.list.Add(element);
        }

        public T Remove(int index)
        {
            var element = this.list[index];
            this.list.RemoveAt(index);
            return element;
        }

        public bool Contains(T item)
        {
            return this.list.Contains(item);
        }

        public void Swap(int index1, int index2)
        {
            var temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            return this.list.Count(e => e.CompareTo(element) > 0);
        }

        public T Max()
        {
           return this.list.Max();
        }

        public T Min()
        {
            return this.list.Min();
        }

        public override string ToString()
        {
            return $"{string.Join(Environment.NewLine, this.list)}";
        }
    }
}
