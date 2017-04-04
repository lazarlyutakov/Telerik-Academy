using System;

namespace reverseString
{
    class reverseString
    {
        static void Main()
        {
            string str = Console.ReadLine();
            char[] reversedStr = new char[str.Length];

            for (int i = 0, j = str.Length - 1; i < str.Length; j--, i++)
            {
                reversedStr[j] = str[i];
            }
            Console.WriteLine(reversedStr);
        }
    }
}
///// VTORO RESHENIE
//using System;
//using System.Text;

//class ReverseString
//{
//    static string ReverseText(string text)
//    {
//        StringBuilder sb = new StringBuilder();

//        for (int i = text.Length - 1; i >= 0; i--)
//        {
//            sb.Append(text[i]);
//        }

//        return sb.ToString();
//    }

//    static void Main(string[] args)
//    {
//
//        string text = Console.ReadLine();

//        string result = ReverseText(text);
//        Console.WriteLine(result);
//    }
//}

//// TRETO Reshenie

//    using System;

//class Program
//{
//    static void Main()
//    {
//        char[] str = Console.ReadLine().ToCharArray();

//        Array.Reverse(str);

//        Console.WriteLine(str);
//    }
//}