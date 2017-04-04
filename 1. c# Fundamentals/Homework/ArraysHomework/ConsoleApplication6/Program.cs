using System;

    class Program
    {
        static void Main()
        {

        int n = 6;
        int k = 3;
        int sum = 0;
        int bestSum = sum;
        int tmpIndex = 0;
        int endIndexOfMax = 0;


        Console.Write("N = ");
        string strN = Console.ReadLine();

        Console.Write("K = ");
        string strK = Console.ReadLine();

        if (!int.TryParse(strN, out n) || !int.TryParse(strK, out k) || k > n)
        {
            Console.WriteLine("Invalid numbers!");
        }
        else
        {
            int[] array = new int[n];

            // Get all array values
            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter array element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < n - k + 1; j++)
            {
                for (int p = j; p < k + j; p++)
                {
                    sum += array[p];
                    tmpIndex = p;
                }

                if (sum > bestSum)
                {
                    bestSum = sum;
                    endIndexOfMax = tmpIndex;
                }

                sum = 0;
            }

            Console.WriteLine("The maximal sum of {0} sequent elements is: {1}", k, bestSum);
            Console.Write("{ ");

            for (int i = endIndexOfMax - k + 1; i <= endIndexOfMax; i++)
            {
                if (i == endIndexOfMax)
                {
                    Console.Write("{0}", array[i]);
                }
                else
                {
                    Console.Write("{0}, ", array[i]);
                }
            }

            Console.WriteLine(" }");
        }
    }
    }

