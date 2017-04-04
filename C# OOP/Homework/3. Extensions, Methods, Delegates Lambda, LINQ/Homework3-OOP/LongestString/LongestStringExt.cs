using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    public static class LongestStringExt
    {
        public static void FindLongestString (this List<string> someText)
        {
            string longest = someText.OrderByDescending(word => word.Length).First();
            Console.WriteLine("The longest string from your input is : {0}", longest);
        }
    }
}
