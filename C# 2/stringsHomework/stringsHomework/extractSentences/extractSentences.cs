using System;
using System.Text;

namespace extractSentences
{
    class extractSentences
    {
        static void Main()
        {
            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();

            string[] splittedText = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder newText = new StringBuilder();
            StringBuilder charSep = new StringBuilder();

            foreach (var sentence in splittedText)
            {

                charSep.Clear();

                for (int i = 0; i < sentence.Length; i++)
                {
                    if (char.IsLetter(sentence[i]) == false)
                    {
                        charSep.Append(sentence[i]);
                    }
                }


                char[] splitCh = charSep.ToString().ToCharArray();
                string[] splittedSent = sentence.Split(splitCh, StringSplitOptions.RemoveEmptyEntries);


                if (Array.IndexOf(splittedSent, keyWord) != -1)
                {
                    newText.Append(sentence.Trim() + ". ");
                }
            }

            Console.WriteLine(newText.ToString().Trim());
        }
    }
}
