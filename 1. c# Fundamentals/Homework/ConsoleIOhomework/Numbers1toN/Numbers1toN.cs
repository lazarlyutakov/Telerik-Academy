using System;

class Numbers1toN
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        if (N >= 1 && N < 1000)
        {
            for (int k = 0; k < N; k++)
            {
                Console.WriteLine(k + 1);
            }
        }
    }

}
    

