using System;
using System.Text;

namespace parseTags
{
    class parseTags
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(FormatToUpper(input));

        }


        static string FormatToUpper(string input)
        {
            StringBuilder temp = new StringBuilder(input);

            int leftEnd = 0;
            int rightEnd = 0;

            while ((leftEnd = input.IndexOf("<upcase>", leftEnd)) >= 0 && (rightEnd = input.IndexOf("</upcase>", rightEnd)) >= 0)
            {
                string toBeFormatted = input.Substring(leftEnd, rightEnd - leftEnd);
                string toUpper = toBeFormatted.ToUpper();
                temp.Replace(toBeFormatted, toUpper);
                leftEnd++;
                rightEnd++;
            }

            temp.Replace("<upcase>", "");
            temp.Replace("</upcase>", "");
            temp.Replace("<UPCASE>", "");
            temp.Replace("</UPCASE>", "");


            return temp.ToString();
        }
    }
}
