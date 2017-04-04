using System;

class selectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int temp = 0;

        for(int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for( int j = 0; j < n - 1 ; j++)
        {
            int minNum = array[j];

            for(int k = j+1; k < n; k++)
            {
                if(array[k] < minNum)
                {
                    minNum = array[k];

                    if (minNum != array[j])
                    {
                        temp = array[j];
                        array[j] = array[k];
                        array[k] = temp;
                    }
                    
                }
                
            }
            
        }

        foreach (int item in array)
        {
            Console.WriteLine(item);
        }

    }
}

