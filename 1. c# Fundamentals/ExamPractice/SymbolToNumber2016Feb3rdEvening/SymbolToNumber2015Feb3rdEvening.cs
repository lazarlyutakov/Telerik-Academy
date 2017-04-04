using System;

class SymbolToNumber2016Feb3rdEvening
{
    static void Main()
    {
        int secret = int.Parse(Console.ReadLine());
        string inputText = Console.ReadLine();
        double result = 0;

        for(int i = 0; i <= inputText.Length; i++)
        {
            char symbol = inputText[i];

            if(symbol == '@')
            {
                break;
            }

            if(symbol >= 'a' && symbol <= 'z' || symbol >= 'A' && symbol <= 'Z')
            {
                result = ( symbol - 0 ) * secret + 1000;
                
            }

            else if(symbol >= '0' && symbol <= '9')
            {
                result = secret + ( symbol - 0 ) + 500;
            }
            else
            {
                result = (symbol - 0 ) - secret;
            }

            if(i % 2 == 0)
            {
                result /= 100;
                Console.WriteLine("{0:f2}", result);
            }

            else
            {
                result *= 100;
                Console.WriteLine("{0}", result);
            }
           
        }
       
    }
}




