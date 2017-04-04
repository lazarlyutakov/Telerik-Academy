using System;

    class FindBits
    {
        static void Main()
        {
        uint s = uint.Parse(Console.ReadLine());
        uint[] n = new uint[s];
        string binaryS = Convert.ToString(s, 2);
        uint i;
        for ( i = 0; i < n.Length; i++)
        {
            n[i] = uint.Parse(Console.ReadLine());
        }

        string binaryN = Convert.ToString(n[i], 2);



        //for (int index = 1; index < array.Length; index += 2)
        //{
        //    array[index] = -1;
        //}

    }
    }

