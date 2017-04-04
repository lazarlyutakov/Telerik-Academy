namespace QualityMethods.Printing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Contains methods, that are printing on the console;
    /// </summary>
    internal class ConsoleLogger
    {
        public ConsoleLogger()
        {
        }

        /// <summary>
        /// Prints a number on the console in the required format.
        /// </summary>
        /// <param name="number">The number to print.</param>
        /// <param name="format">Formats, allowed as input.</param>
        internal static void PrintAsNumber(object number, string format)
        {
            if (number == null)
            {
                throw new ArgumentNullException("Number is null!");
            }

            if (format == null)
            {
                throw new ArgumentNullException("Format is null");
            }

            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("Invalid input");
            }
        }
    }
}
