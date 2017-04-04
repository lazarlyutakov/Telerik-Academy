using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumarableExten
{
   public static class IEnumExtensions
    {
        public static T Sum<T>(this IEnumerable<T> numbers)
        {
            T sum = default(T);

            foreach (var num in numbers)
            {
                sum += (dynamic)num;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> numbers)
        {
            T product = (dynamic)1;

            foreach (var numb in numbers)
            {
                product *= (dynamic)numb;
            }

            return product;
        }

        public static T MinimalValue<T>(this IEnumerable<T> numbers)
        {
            T minimal = numbers.First();

            foreach (var num in numbers)
            {
                if(minimal > (dynamic)num)
                {
                    minimal = num;
                }
            }
            return minimal;
        }

        public static T MaximalValue<T>(this IEnumerable<T> numbers)
        {
            T maximal = numbers.First();

            foreach (var num in numbers)
            {
                if (maximal < (dynamic)num)
                {
                    maximal = num;
                }
            }
            return maximal;
        }

        public static T Avarage<T>(this IEnumerable<T> numbers)
        {
            T average = default(T);
            T sum = default(T);

            foreach (var num in numbers)
            {
                sum += (dynamic)num;
                average = (dynamic)sum / numbers.Count();
            }
            return average;
        }

    }
}
