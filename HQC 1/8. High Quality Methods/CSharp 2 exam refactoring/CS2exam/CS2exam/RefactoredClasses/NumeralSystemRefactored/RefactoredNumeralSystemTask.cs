namespace CS2exam.RefactoredClasses.NumeralSystemRefactored
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Refactored class, that converts coded input into a decimal number and finds the product of its digits.
    /// </summary>
    public class RefactoredNumeralSystemTask
    {
        public static string[] ReplaceInputSymbolsWithPredefined()
        {
            // Replace input string with a corresponding 
            // numeric or alphabetical character.
            string messageToBeReplaced = Console.ReadLine()
                               .Replace("ocaml", "0")
                               .Replace("haskell", "1")
                               .Replace("scala", "2")
                               .Replace("f#", "3")
                               .Replace("commonlisp", "d")
                               .Replace("rust", "5")
                               .Replace("standardml", "9")
                               .Replace("clojure", "7")
                               .Replace("erlang", "8")
                               .Replace("ml", "6")
                               .Replace("racket", "a")
                               .Replace("elm", "b")
                               .Replace("mercury", "c")
                               .Replace("lisp", "4")
                               .Replace("scheme", "e")
                               .Replace("curry", "f");

            // Split the message into single characters and stores them in char array.
            string[] splittedMessage = messageToBeReplaced.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return splittedMessage;
        }
     
        public static BigInteger FindProductOfDigits(string[] splittedMessage)
        {
            BigInteger product = 1;

            foreach (var word in splittedMessage)
            {
                BigInteger inDecimal = ConvertToDecimal(word);
                product *= inDecimal;
            }

            return product;
        }

        private static BigInteger ConvertToDecimal(string word)
        {
            int digit = 0;
            ulong convertedValue = 0;
            int positionIndex = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'a' && word[i] <= 'f')
                {
                    digit = word[i] - 'a' + 10;
                    positionIndex = word.Length - i - 1;
                    convertedValue += (ulong)digit * (ulong)BigInteger.Pow(16, positionIndex);
                }
                else if (word[i] >= '0' && word[i] <= '9')
                {
                    digit = word[i] - '0';
                    positionIndex = word.Length - i - 1;
                    convertedValue += (ulong)digit * (ulong)BigInteger.Pow(16, positionIndex);
                }
            }

            return convertedValue;
        }
    }
}
