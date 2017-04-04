using System;
using System.Linq;

class compareArraysDrReshenie
{
    static void Main()
    {
        ushort arraySize = ushort.Parse(Console.ReadLine());

        ushort[] firstArray = new ushort[arraySize];
        ushort[] secondArray = new ushort[arraySize];
        if (1 <= arraySize && arraySize <= 20)
        {
            for (int i = 0; i < arraySize; i++)
            {
                firstArray[i] = ushort.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arraySize; i++)
            {
                secondArray[i] = ushort.Parse(Console.ReadLine());
            }

            if (firstArray.SequenceEqual(secondArray))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }

    }
}
