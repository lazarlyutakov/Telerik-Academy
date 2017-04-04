//using System;
//using System.Numerics;



//namespace FunctionalNumeralSystem
//{
//    class FunctionalNumeralSystem
//    {


//        static void Main()
//        {
//            string message = Console.ReadLine()
//                               .Replace("ocaml", "0")
//                               .Replace("haskell", "1")
//                               .Replace("scala", "2")
//                               .Replace("f#", "3")
//                               .Replace("commonlisp", "d")                              
//                               .Replace("rust", "5")
//                               .Replace("standardml", "9")
//                               .Replace("clojure", "7")
//                               .Replace("erlang", "8")
//                               .Replace("ml", "6")
//                               .Replace("racket", "a")
//                               .Replace("elm", "b")
//                               .Replace("mercury", "c")
//                               .Replace("lisp", "4")
//                               .Replace("scheme", "e")
//                               .Replace("curry", "f");

//            string[] splittedMessage = message.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

           
//            BigInteger product = 1;

//            foreach (var word in splittedMessage)
//            {
//                BigInteger inDec = ConvertToDecimal(word);
//                product *= inDec;
//            }

//            Console.WriteLine(product);
            
//        }

//        static BigInteger ConvertToDecimal(string word)
//        {
//            int digit = 0;
//            ulong temp = 0;
//            int psnInd = 0;

//            for (int i = 0; i < word.Length; i++)
//            {
//                if (word[i] >= 'a' && word[i] <= 'f')
//                {
//                    digit = word[i] - 'a' + 10;
//                    psnInd = word.Length - i - 1;
//                    temp += (ulong)digit * (ulong)BigInteger.Pow(16, psnInd);
//                }

//                else if (word[i] >= '0' && word[i] <= '9')
//                {
//                    digit = word[i] - '0';
//                    psnInd = word.Length - i - 1;
//                    temp += (ulong)digit * (ulong)BigInteger.Pow(16, psnInd);
//                }
//            }
//            return temp;
//        }
//    }
//}
