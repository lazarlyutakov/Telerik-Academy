using System;


namespace randomNumbers
{
    class randomNumbers
    {
        static void Main()
        {
            Random number = new Random();

            for (int i = 0; i <= 10; i++)

            {
                int randNumb = number.Next(100, 200);
                Console.WriteLine(randNumb);
            }
        }
    }
}
