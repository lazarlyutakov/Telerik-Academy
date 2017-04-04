using System;

class indexOfLetters
{
    static void Main()
    {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        string word = Console.ReadLine();

        for (int j = 0; j < word.Length; j++)
        {

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (word[j] == alphabet[i])
                {
                    Console.WriteLine(i);
                }
            }

        }


    }
}

