using System;
using System.Text;



namespace unicodeCharacters
{
    class unicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(ConvertToUnicode(input));
        }



        static string ConvertToUnicode(string input)
        {
            StringBuilder unicode = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                unicode.AppendFormat("\\u{0:X4}", (int)input[i]);
             
            }
            return unicode.ToString();
        }
    }
}











