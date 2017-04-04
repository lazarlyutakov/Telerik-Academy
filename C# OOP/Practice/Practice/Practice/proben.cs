using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice
{
    class proben
    {

        static void Main()
        {
 
            StreamReader reader = new StreamReader(@"..\..\text.txt");
            string fileContent = reader.ReadToEnd();
            Console.WriteLine(fileContent);


        }
    }
}
