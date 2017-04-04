namespace QualityMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using QualityMethods.Calculations;
    using QualityMethods.Models;
    using QualityMethods.Printing;

    public class Startup
    {
        public static void Main(string[] args)
        {
            // Test IsOlderThan method
            Student peter = new Student("Peter", "Ivanov", new OtherInformation(new DateTime(1992, 3, 17), "Sofia"));
            Student stella = new Student("Stella", "Markova", new OtherInformation(new DateTime(1993, 11, 3), "Vidin"));

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));

            // Test MathAssistant Class
            double triangleArea = MathAssistant.CalculateTriangleArea(3, 4, 5);
            double calculateDistance = MathAssistant.CalcDistance(3, -1, 3, 2.5);            
            int findMaxValue = MathAssistant.FindMaxValue(5, -1, 3, 2, 14, 2, 3);

            bool isHorizontal = MathAssistant.IsLineHorizontal(3, -1, 3, 2.5);
            bool isVertical = MathAssistant.IsLineVertical(3, -1, 3, 2.5);
            Console.WriteLine(isHorizontal);
            Console.WriteLine(isVertical);

            // Test DigitConverter Class
            string numberAsDigit = DigitConverter.DigitToWord(5);
            Console.WriteLine(numberAsDigit);

            // Test ConsoleLogger Class
            ConsoleLogger.PrintAsNumber(triangleArea, "f");
            ConsoleLogger.PrintAsNumber(calculateDistance, "%");
            ConsoleLogger.PrintAsNumber(findMaxValue, "r");
        }
    }
}