using System;
using System.Collections.Generic;
using System.Linq;

class sortByStringLenght
{
    static void Main()
    {
        string[] words = { "sam", "kuramiqnko", "pederast", "chuk" };

        Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}

