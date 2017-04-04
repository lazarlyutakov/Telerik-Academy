using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
     public abstract class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public override void AnimalSound()
        {
            Console.WriteLine("Meooow, meooww..");
        }
    }
}
