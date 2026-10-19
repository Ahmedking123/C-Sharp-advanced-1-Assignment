using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace C_Sharp_advanced__1_Assignment
{
    internal static class GenericMethods 
    {
        static void Swap<T>(ref T First,ref T Second)
        {
            T temp = First;
            First = Second;
            Second = temp;
        }
        static T FindMax<T>(T First, T second) where T : INumber<T>
        {
            return First > second ? First : second;
        }
    }
}
