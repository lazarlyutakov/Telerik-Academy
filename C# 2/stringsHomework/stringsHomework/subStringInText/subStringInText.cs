using System;


namespace subStringInText
{
    class subStringInText
    {
        static void Main()
        {
            string pattern = Console.ReadLine();
            string loweredPattern = pattern.ToLower();
            string textToInspect = Console.ReadLine();
            string loweredChars = textToInspect.ToLower();
            int counter = 0;

            int ind = 0;
            while((ind = loweredChars.IndexOf(string.Format("{0}", loweredPattern), ind)) >= 0)
            {
                counter++;
                ind++;
            }
            Console.WriteLine(counter);
        }
    }
}
