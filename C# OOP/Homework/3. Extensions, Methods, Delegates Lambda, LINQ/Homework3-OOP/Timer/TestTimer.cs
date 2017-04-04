using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class TestTimer
    {
        static void Main(string[] args)
        {
            Timer test = new Timer(1, 10);

            test.InternalMethods = delegate ()
            {
                Console.Write("Executed!");
            };

            test.InternalMethods += delegate ()
            {
                Console.WriteLine(" Counter: {0}", test.Counter);
            };

            test.Start();
        }
    }
}
