using System;

    class opitno
    {
        static void Main()
        {
        int number = int.Parse(Console.ReadLine());
        int[] rounds = new int[number];
        int mitskoBrees = 0;
        int mitkosBeersTotal = 0;
        int vladoBeers = 0;
        int vladoBeersTotal = 0;

        for (int i = 0; i < number; i++)
        {
            rounds[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < number; i++)
        {
            foreach (int num in rounds)
            {
                string str = Convert.ToString(num);

                for(int j = 0; j <= str.Length / 2; j++)
                {
                    mitskoBrees += str[j] - '0';
                }
                for(int j = str.Length / 2; j < str.Length; j++)
                {
                    vladoBeers += str[j] - '0';
                }
            }
            

        }


        Console.WriteLine(mitskoBrees);


    }
}

