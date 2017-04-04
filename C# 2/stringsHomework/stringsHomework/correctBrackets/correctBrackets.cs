using System;
using System.Text;

// IMA VTORO I TRETO RESHENIE - DOLU !

namespace correctBrackets
{
    class correctBrackets
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            IsCorrect(expression);
        }

        static void IsCorrect(string input)
        {
            StringBuilder openBracket = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    openBracket.Append(input[i]);
            }

            StringBuilder closingBracket = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ')')
                    closingBracket.Append(input[i]);
            }

            if (openBracket.Length == closingBracket.Length)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}

// VTORO RESHENIE - METOD S RETURN

//using System;
//using System.Text;

//namespace correctBrackets
//{
//    class correctBrackets
//    {
//        static void Main()
//        {
//            string expression = Console.ReadLine();
//            Console.WriteLine(IsCorrect(expression));
//        }

//        static string IsCorrect(string input)
//        {
//            StringBuilder openBracket = new StringBuilder();

//            for (int i = 0; i < input.Length; i++)
//            {
//                if (input[i] == '(')
//                    openBracket.Append(input[i]);
//            }

//            StringBuilder closingBracket = new StringBuilder();

//            for (int i = 0; i < input.Length; i++)
//            {
//                if (input[i] == ')')
//                    closingBracket.Append(input[i]);
//            }

//            if (openBracket.Length == closingBracket.Length)
//            {
//                return "Correct";
//            }
//            else
//            {
//                return "Incorrect";
//            }
//        }
//    }
//}


    // TRETO RESHENIE - S COUNTER
//    using System;
//using System.Text;
 
//    class CheckIfBracketsArePutCorrectly
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter some expression: ");
//        string expression = Console.ReadLine();

//        int counter = 0;

//        for (int i = 0; i < expression.Length; i++)
//        {
//            if (expression[i] == '(')
//            {
//                counter++;
//            }
//            if (expression[i] == ')')
//            {
//                counter--;
//            }
//            if (counter < 0)
//            {
//                break;
//            }
//        }

//        if (counter == 0)
//        {
//            Console.WriteLine("Correct expression!");
//        }
//        else
//        {
//            Console.WriteLine("Incorrect expression!");
//        }
//    }
//}

