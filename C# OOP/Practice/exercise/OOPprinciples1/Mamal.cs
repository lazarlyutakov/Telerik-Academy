using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheretence
{
    class Mamal
    {
        public int Age { get; set; }

        public Mamal(int age)
        {
            this.Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine("Shut the fuck up ! I'm sleepin !");
        }

    }
}
