using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate double Delegate(int a, int b);
    class Class1
    {
        static double fn_ToHookToTheDelegate(int val1, int val2)
        {
            return val1 * val2;
        }

        static void Main(string[] args)
        {
            //Creating the Delegate Instance
            Delegate delObj = new Delegate(fn_ToHookToTheDelegate);
            Console.Write("Please Enter Values");
            int v1 = Int32.Parse(Console.ReadLine());
            int v2 = Int32.Parse(Console.ReadLine());
            //Call delegate for processing
            double res = delObj(v1, v2);
            Console.WriteLine("Result: " + res);
            Console.ReadLine();
        }
    }
}
