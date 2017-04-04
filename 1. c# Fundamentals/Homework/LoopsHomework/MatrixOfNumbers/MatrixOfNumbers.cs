using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        for (int row = 1; row <= n; row++)
        {
            for (int culumn = 1; culumn <= n; culumn++)
            {
                Console.Write("{0} ", (row + culumn - 1));
            }
            Console.WriteLine();
        }
    }

}

//variant2
//int n = int.Parse(Console.ReadLine());

//        for (int i = 1; i <= n; i++)
//        {
//            for (int j = i; j<n + i; j++)
//            {
//                Console.Write(j + " ");
//            }
//            Console.WriteLine();



