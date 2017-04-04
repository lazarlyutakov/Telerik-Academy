using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class StartUpLongestString
    {
        static void Main(string[] args)
        {
            Console.Write("Ho many words do you want to input ?  ");
            int numbOfWords = int.Parse(Console.ReadLine());
            List<string> someText = new List<string>();


            for (int i = 0; i < numbOfWords; i++)
            {
                 someText.Add(Console.ReadLine());
            }

            Console.WriteLine();
            LongestStringExt.FindLongestString(someText);
            
        }
    }
}
