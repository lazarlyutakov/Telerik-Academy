using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples2
{
    class Line : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("I am a line : ");
            Console.WriteLine("-----");
        }
    }
}
