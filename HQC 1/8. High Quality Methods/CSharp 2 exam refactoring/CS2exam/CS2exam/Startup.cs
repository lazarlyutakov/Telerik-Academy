namespace CS2exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CS2exam.RefactoredClasses.NumeralSystemRefactored;
    using CS2exam.RefactoredClasses.NumeralSystemRefactored.Logger;

    public class Startup
    {
        public static void Main(string[] args)
        {
            // Test RefactoredNumericalSystem
            var replacedMessage = RefactoredNumeralSystemTask.ReplaceInputSymbolsWithPredefined();
            var productOfDigits = RefactoredNumeralSystemTask.FindProductOfDigits(replacedMessage);
            ConsoleLogger.PrintProductOfDigits(productOfDigits);
        }
    }
}
