using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_advanced__1_Assignment
{
    internal class SafeList<T>
    {
        private readonly List<T> _items = [];

        public T GetValue(int Index) 
        {
            if (_items[Index] != null)
            {
                return _items[Index];
            }
            return default!;
        }
    }
}
