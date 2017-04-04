using System;
using System.Text;

namespace seriesOfLetters
{
    class seriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0, j = i + 1; i < input.Length && j < input.Length; i++, j++)
            {
                if (input[i] != input[j])
                {
                    result.Append(input[i]);
                }
            }

            result.Append(input[input.Length - 1]);
            Console.WriteLine(result);
        }
    }
}
