using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_advanced__1_Assignment
{
    internal static class GenericMethods<T>
    {
        static void Swap(ref T First,ref T Second)
        {
            T temp = First;
            First = Second;
            Second = temp;
        }
    }
}
