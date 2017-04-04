namespace QualityMethods.Calculations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class, that converts integer to string
    /// </summary>
    internal class DigitConverter
    {
        public DigitConverter()
        {
        }

        public int Number { get; }

        /// <summary>
        /// A static method, which takes a number as input and converts it to string representation.
        /// </summary>
        /// <param name="number">The number to be converted</param>
        /// <returns>The number, written as a string.</returns>
        internal static string DigitToWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "You must enter a single digit!";
            }
        }
    }
}
