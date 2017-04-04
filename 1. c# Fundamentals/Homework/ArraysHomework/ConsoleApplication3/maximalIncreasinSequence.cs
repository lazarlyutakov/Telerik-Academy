using System;

class maximalIncreasinSequence
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        int counter = 1;
        int counterFinal = 0;

        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

        }

        for (int i = array.Length - 1; i > 0; i--)
        {
            if (array[i] - 1 == array[i - 1])
            {
                counter++;
                if (counter >= counterFinal)
                {
                    counterFinal = counter;
                    
                }
                
            }
            else if(counter == 1)
            {
                counterFinal = 0;
            }

        }

        Console.WriteLine(counterFinal);
    }

}


