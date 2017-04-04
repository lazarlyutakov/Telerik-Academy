using System;

namespace stringLenght
{
    class stringLenght
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if(input.Length < 20)
            {
                Console.WriteLine("{0}", input.PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
