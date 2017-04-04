using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    public class Dog : Mamal
    {
        public string Breed { get; private set; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            this.Breed = breed;
        }

        internal void WagTail()
        {
            Console.WriteLine("{0} is {1} wagging his {2} - aged tail",
                this.Name, this.Breed, this.Age);
        }

    }
}
