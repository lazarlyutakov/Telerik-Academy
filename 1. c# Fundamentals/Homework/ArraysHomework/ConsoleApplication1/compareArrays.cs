using System;

class compareArrays
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] firstArray = new int[number];
        int[] secondArray = new int[number];

        bool isEqual = true;
        string answer = "";

        if (number >= 1 && number <= 20)
        {

            for (int i = 0; i < number; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < number; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < number; i++)
            {
                if (firstArray[i] == secondArray[i] && firstArray[firstArray.Length - i -1] == secondArray[secondArray.Length - i - 1])
               {
                    isEqual = true;
                    answer = Convert.ToString(isEqual);
                    answer = "Equal";
                }
                else 
                {
                    isEqual = false;
                    answer = Convert.ToString(isEqual);
                    answer = "Not equal";
                }

            }

            Console.WriteLine(answer);
        }

    }
}







