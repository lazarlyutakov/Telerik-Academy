using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples2
{
    internal abstract class Figure
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a figure of unknown kind :");
            Console.WriteLine(this.GetType().Name);
        }
    }
}
