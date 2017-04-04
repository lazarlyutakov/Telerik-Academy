using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class TestGenericList
    {
        static void Main()
        {
            GenericList<int> newList = new GenericList<int>(3);

            newList.Add(5);
            newList.Add(4);
            newList.Add(6);
            newList.Add(7);

            Console.WriteLine(newList[2]);
            newList[1] = 10;
            Console.WriteLine(newList[2]);

            newList.RemoveAtPsn(2);
            Console.WriteLine(newList[2]);

            Console.WriteLine(newList.MinValue());
            Console.WriteLine(newList.MaxValue());

            newList.ClearList();
            Console.WriteLine();

        }
    }
}
