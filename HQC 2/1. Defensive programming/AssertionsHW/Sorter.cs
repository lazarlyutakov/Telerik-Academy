namespace AssertionsHW
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class that provides methods for sorting of a collection. 
    /// </summary>
    internal class Sorter
    {
        public static void SelectionSort<T>(T[] arrayToSort) where T : IComparable<T>
        {
            // If no collection provided, exception will be thrown.
            Debug.Assert(arrayToSort != null, "You must assign an array!");

            for (int index = 0; index < arrayToSort.Length - 1; index++)
            {
                int minElementIndex = SearchMethods.FindMinElementIndex(arrayToSort, index, arrayToSort.Length - 1);
                Swapper.Swap(ref arrayToSort[index], ref arrayToSort[minElementIndex]);
            }
        }
    }
}
