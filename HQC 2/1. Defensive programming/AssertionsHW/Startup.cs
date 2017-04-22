namespace AssertionsHW
{
    using System;
    using System.Linq;
    using System.Diagnostics;

    public class Startup
    {
        
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            Sorter.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            Sorter.SelectionSort(new int[0]); // Test sorting empty array
            Sorter.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(SearchMethods.BinarySearch(arr, -1000));
            Console.WriteLine(SearchMethods.BinarySearch(arr, 0));
            Console.WriteLine(SearchMethods.BinarySearch(arr, 17));
            Console.WriteLine(SearchMethods.BinarySearch(arr, 10));
            Console.WriteLine(SearchMethods.BinarySearch(arr, 1000));
        }
    }
}
