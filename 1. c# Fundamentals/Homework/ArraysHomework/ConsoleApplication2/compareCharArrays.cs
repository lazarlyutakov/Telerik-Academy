using System;

class compareCharArrays
{
    static void Main()
    {
        string firstWord = Console.ReadLine();//.Split(' ');
        string secondWord = Console.ReadLine();//.Split(' ');

        if (firstWord == secondWord)
        {
            Console.WriteLine("=");
        }
        else
        {

            for (int i = 0; i < Math.Min(firstWord.Length, secondWord.Length); i++)
            {
                if (firstWord[i] > secondWord[i])
                {
                    Console.WriteLine(">");
                    break;

                }
                else if (firstWord[i] < secondWord[i])
                {
                    Console.WriteLine("<");
                    break;

                }
                else if (i == Math.Min(firstWord.Length, secondWord.Length) - 1)
                {
                    if (firstWord.Length > secondWord.Length)
                    {
                        Console.WriteLine(">");

                    }
                    else if (firstWord.Length < secondWord.Length)
                    {
                        Console.WriteLine("<");
                    }
                }
            }

        }
    }
}
