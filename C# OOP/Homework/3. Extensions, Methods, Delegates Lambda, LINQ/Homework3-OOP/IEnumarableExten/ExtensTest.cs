using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumarableExten
{
    class ExtensTest
    {
        static void Main(string[] args)
        {
            var test = new List<int>();

            test.Add(1);
            test.Add(5);
            test.Add(9);

           
            Console.WriteLine("The sum is : " + test.Sum());
            Console.WriteLine("The product is : " + test.Product());
            Console.WriteLine("The minimal number is : " + test.MinimalValue());
            Console.WriteLine("The maximal number is : " + test.MaximalValue());
            Console.WriteLine("The average is : " + test.Average());
        }
    }
}
