namespace ExceptionHandling.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class StringHandler
    {
        public static T[] Subsequence<T>(T[] array, int startIndex, int count)
        {
            if (array.Length < 1)
            {
                throw new ArgumentOutOfRangeException("The array must not be empty!");
            }

            if (startIndex < 0 || startIndex > array.Length - 1)
            {
                throw new ArgumentOutOfRangeException("The start index must be greater or equal to zero and not longer than the array's length!");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("Count must be greater or equal to zero!");
            }

            if (startIndex + count > array.Length)
            {
                throw new ArgumentOutOfRangeException("You are out of the array's bounderies!");
            }

            List<T> result = new List<T>();

            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(array[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("A string must be specified!");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("Count must be greater or equal to zero!");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("Count must be in the array's limits!");
            }

            StringBuilder result = new StringBuilder();

            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }
    }
}
