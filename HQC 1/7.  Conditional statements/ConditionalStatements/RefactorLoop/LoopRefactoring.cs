namespace RefactorLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LoopRefactoring
    {
        public static void ValueSearch(int[] arrayToInspect, int targetValue)
        {
            bool isExpectedValueFound = false;

            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(arrayToInspect[i]);

                isExpectedValueFound = AerConditionsMet(i, targetValue, arrayToInspect[i]);
                if (isExpectedValueFound)
                {
                    break;
                }
            }

            if (isExpectedValueFound)
            {
                Console.WriteLine("Value Found");
            }
        }

        private static bool AerConditionsMet(int index, int targetValue, int valueFromArray)
        {
            var areConditionsMet = false;

            if (index % 10 == 0 && valueFromArray == targetValue)
            {
                areConditionsMet = true;
            }

            return areConditionsMet;
        }
    }
}
