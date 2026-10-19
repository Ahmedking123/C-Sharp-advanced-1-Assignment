using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_advanced__1_Assignment
{
    internal interface IRepositry<T>
    {
        void Add(T Item);

        T GetValue(int Id);

        void Remove(int ID);
    }
}
