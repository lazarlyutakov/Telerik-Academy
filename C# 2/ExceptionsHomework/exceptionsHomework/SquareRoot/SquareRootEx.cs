using System;

namespace SquareRootEx
{
    class SquareRootEx
    {
        
        static void Main()
        {
            double result = 0;
            try
            {
               double number = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                result = Math.Sqrt(number);
                string answer = result.ToString();

                if (answer == "NaN")
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    Console.WriteLine("{0:f3}", result);
                }                            
            }

            catch (Exception)           
            {
                
                Console.WriteLine("Invalid number");
            }

            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
