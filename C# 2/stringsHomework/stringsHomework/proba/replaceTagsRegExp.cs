using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string formattedText = Regex.Replace(input, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
        Console.WriteLine(formattedText);
    }
}
