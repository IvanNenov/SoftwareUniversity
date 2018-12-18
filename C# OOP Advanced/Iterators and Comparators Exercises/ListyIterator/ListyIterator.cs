using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> list;
        private int index;

        public ListyIterator(List<T> list)
        {
            this.index = 0;
            this.list = list;
        }

        public bool Move()
        {
            if (index < list.Count -1)
            {
                index++;
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            if (index < list.Count -1 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (list.Count != 0)
            {
                Console.WriteLine(list[this.index]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
    }
}
