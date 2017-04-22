namespace ExceptionHandling
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Exams;
    using Models;
    using Utils;

    public class Startup
    {
        public static void Main()
        {
            var substr = StringHandler.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = StringHandler.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = StringHandler.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = StringHandler.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(StringHandler.ExtractEnding("I love C#", 2));
            Console.WriteLine(StringHandler.ExtractEnding("Nakov", 4));
            Console.WriteLine(StringHandler.ExtractEnding("beer", 4));

            // if uncommented, crashes the program, because of the predefined validations!
            // Console.WriteLine(StringHandler.ExtractEnding("Hi", 100));

            try
            {
                PrimeChecker.CheckPrime(23);
                Console.WriteLine("23 is prime.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                PrimeChecker.CheckPrime(33);
                Console.WriteLine("33 is prime.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
