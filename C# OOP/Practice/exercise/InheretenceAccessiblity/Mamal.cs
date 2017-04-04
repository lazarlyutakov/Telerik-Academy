using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretenceAccessiblity
{
    class Mamal : Creature
    {
        public int Age { get; set; }

        public Mamal(string name, int age) : base(name)
        {
            this.Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine("Shhhh, {0} is sleeping", this.Name);
        }
    }
}
