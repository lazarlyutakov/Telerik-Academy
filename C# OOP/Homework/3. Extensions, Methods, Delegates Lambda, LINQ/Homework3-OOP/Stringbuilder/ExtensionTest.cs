using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder
{
    class ExtensionTest
    {
      static void Main()
        {
            StringBuilder someText = new StringBuilder();
            someText.Append("Extension methods test");
            Console.WriteLine(someText.Substring(2,8).ToString()); 
        }
    }
}
