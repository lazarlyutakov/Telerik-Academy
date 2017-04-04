using System;

class Speeds
{
    static void Main()
    {
        int cars = int.Parse(Console.ReadLine());
        bool isFirst = true;
        int speedBefore = int.MinValue;
        int speed = 0;
        int finalSum = 0;
        int finalLenght = 0;
        int sum = 0;
        int lenght = 0;

        bool isUpdated = false;

        for (int i = 0; i < cars; i++)
        {
            speed = int.Parse(Console.ReadLine());
            isUpdated = false;

            if (isFirst)
            {
                isFirst = false;
                speedBefore = speed;
                lenght = 1;
                sum = speed;
            }

            else if (speed <= speedBefore)
            {
                isUpdated = true;
                speedBefore = speed;

                if (lenght > finalLenght)
                {
                    finalLenght = lenght;
                    finalSum = sum;
                }

                else if (lenght == finalLenght)
                {
                    finalSum = (finalSum > sum) ? finalSum : sum;
                }

                sum = speed;
                lenght = 1;
            }

            else
            {
                ++lenght;
                sum += speed;
            }
        }

        if (!isUpdated)
        {
            if(lenght > finalLenght)
            {
                finalLenght = lenght;
                finalSum = sum;
            }
            else if ( lenght == finalLenght)
            {
                finalSum = (finalSum > sum) ? finalSum : sum;
            }
        }


            Console.WriteLine(finalSum);
        }
    }



