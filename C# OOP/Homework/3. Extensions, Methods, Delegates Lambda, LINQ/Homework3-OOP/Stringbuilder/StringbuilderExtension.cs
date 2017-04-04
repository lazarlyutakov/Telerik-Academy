using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder
{
    public static class StringbuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int length)
        {
            if (index < 0 || index > text.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                StringBuilder answer = new StringBuilder();

                for (int i = index; i < index + length; i++)
                {
                    answer.Append(text[i]);
                }
                return answer;
            }
        }

    }
}
