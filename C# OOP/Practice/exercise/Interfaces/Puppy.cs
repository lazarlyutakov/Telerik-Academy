using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
   public class Puppy : Dog
    {
        public int Size { get; private set; }


        public Puppy(string name, int age, string breed, int size) : base(name, age, breed)
        {
            this.Size = size;
        }

        public void Poop()
        {
            Console.WriteLine("The small Puppy {0} {1} pooped", this.Name, this.Size);
        }
    }
}
