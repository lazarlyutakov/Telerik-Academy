namespace AssertionsHW
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Swapper
    {
        /// <summary>
        /// A static method, that swaps the positions of two parameters.
        /// </summary>
        /// <typeparam name="T">Type of the parameters.</typeparam>
        /// <param name="x">First parameter</param>
        /// <param name="y">Second parameter</param>
        public static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null, "You must assign a value for x parameter!");
            Debug.Assert(y != null, "You must assign a value for y parameter!");

            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
