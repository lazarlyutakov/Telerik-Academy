using System;
using System.Text;

class ReplaceTags
{
    static void Main()
    {
        string input = Console.ReadLine();

        StringBuilder formattedText = new StringBuilder();
        int openningTagInd = input.IndexOf("<a href=");
        int closingTagInd = input.IndexOf("</a>");
        int indCurrent = 0;

        while (openningTagInd != -1 || closingTagInd != -1)
        {
            string currPart = input.Substring(indCurrent, openningTagInd - indCurrent);
            string toEdit = input.Substring(openningTagInd, closingTagInd - openningTagInd + "</a>".Length);
            string url = "(" + toEdit.Substring(" < a href = ".Length + 1, (toEdit.IndexOf(">") - "<a href=".Length - 1 - 1)) + ")";
            string innerText = "[" + toEdit.Substring(toEdit.IndexOf(">") + 1, toEdit.LastIndexOf("<") - toEdit.IndexOf(">") - 1) + "]";

            formattedText.Append(currPart);
            formattedText.Append(innerText);
            formattedText.Append(url);

            indCurrent = closingTagInd + "</a>".Length;
            openningTagInd = input.IndexOf("<a href=", openningTagInd + 1);
            closingTagInd = input.IndexOf("</a>", closingTagInd + 1);

            if (openningTagInd == -1 && closingTagInd == -1)
            {
                currPart = input.Substring(indCurrent);
                formattedText.Append(currPart);
            }
        }

        Console.WriteLine(formattedText);
    }
}