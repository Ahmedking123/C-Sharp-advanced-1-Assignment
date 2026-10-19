using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_advanced__1_Assignment
{
    internal class Container<T>
    {
        private readonly List<T> list = new List<T>();

        public void Add(T Item)
        {
            list.Add(Item);
        }
        public T Get(int index)
        {
            return list[index];
        }
    }
}
