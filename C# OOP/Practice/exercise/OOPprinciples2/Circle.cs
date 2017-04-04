using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples2
{
    internal class  Circle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("I am a circle : ");
            Console.WriteLine("----");
            Console.WriteLine("|   |");
            Console.WriteLine("----");
        }
    }
}
