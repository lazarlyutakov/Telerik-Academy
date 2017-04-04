using System;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {

            int[] numbers = new int[12];
            numbers[0] = 1; numbers[11] = 100;

            try
            {
                for (int i = 1; i < numbers.Length - 1; i++)
                {
                    ReadNumber(numbers);
                    if (numbers[i] <= numbers[i - 1] || numbers[i] >= numbers[11])
                    {
                        throw new ArgumentException("out of range");
                    }

                }
                Console.WriteLine(string.Join(" < ", numbers));
            }
            catch
            {
                Console.WriteLine("Exception");
                return;
            }

        }

        static int[] ReadNumber(int[] numbers)
        {
            for (int i = 0; i < 11; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }
    }
}



