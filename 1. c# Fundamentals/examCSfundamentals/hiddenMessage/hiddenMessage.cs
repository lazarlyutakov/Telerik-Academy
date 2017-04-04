using System;

class hiddenMessage
{
    static void Main()
    {

        //video

        string textToDecode = string.Empty;
        string indexOfSymbol = string.Empty;
        string symbolToSkip = string.Empty;
        int i = 0;
        int j = 0;
        while (true)
        {
            indexOfSymbol = (Console.ReadLine());

            if (indexOfSymbol == "end")
            {
                break;
            }
            symbolToSkip = (Console.ReadLine());
            textToDecode = Console.ReadLine();

            for (i = int.Parse(indexOfSymbol); i < textToDecode.Length; i++)
            {

                for (j = int.Parse(symbolToSkip); j < textToDecode.Length; j++)
                {
                    j = int.Parse(indexOfSymbol) + int.Parse(symbolToSkip);
                }
            }
        }

        Console.WriteLine(textToDecode[i] + textToDecode[j]);

    }
}

