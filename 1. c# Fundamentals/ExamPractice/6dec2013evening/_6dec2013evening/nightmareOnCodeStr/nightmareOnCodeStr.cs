using System;

class nightmareOnCodeStr
{
    static void Main()
    {
        string text = Console.ReadLine();

        int counter = 0;
        int sum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (((i % 2) != 0) && (text[i] >= '0') && (text[i] <= '9'))
            {
                counter++;
                sum += (text[i] - '0');
            }
        }
        Console.WriteLine("{0} {1}", counter, sum);
    }
}

