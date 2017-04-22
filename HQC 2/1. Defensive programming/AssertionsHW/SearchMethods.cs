namespace AssertionsHW
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class, that provides various methods for searching in a collection.
    /// </summary>
    internal class SearchMethods
    {
        public static int BinarySearch<T>(T[] arrayToSearchIn, T value) where T : IComparable<T>
        {
            Debug.Assert(arrayToSearchIn != null, "You must assign an array!");
            Debug.Assert(value != null, "Value to be searched cannot be null!");

            return BinarySearch(arrayToSearchIn, value, 0, arrayToSearchIn.Length - 1);
        }

        public static int BinarySearch<T>(T[] arrayToSearchIn, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arrayToSearchIn != null, "You must assign an array!");
            Debug.Assert(value != null, "Value to be searched cannot be null!");
            Debug.Assert(startIndex <= 0 || startIndex > arrayToSearchIn.Length - 2 || startIndex <= endIndex, "Enter a valid start index!");
            Debug.Assert(endIndex < 1 || endIndex > arrayToSearchIn.Length - 1 || startIndex <= endIndex, "Enter a valid end index!");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arrayToSearchIn[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arrayToSearchIn[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }

        public static int FindMinElementIndex<T>(T[] arrayToSearchIn, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arrayToSearchIn != null, "You must assign an array!");
            Debug.Assert(startIndex <= 0 || startIndex > arrayToSearchIn.Length - 2 || startIndex <= endIndex, "Enter a valid start index!");
            Debug.Assert(endIndex < 1 || endIndex > arrayToSearchIn.Length - 1 || startIndex <= endIndex, "Enter a valid end index!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arrayToSearchIn[i].CompareTo(arrayToSearchIn[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }
    }
}