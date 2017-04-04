using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretenceAccessiblity
{
    class Dog : Mamal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
   
            this.Breed = breed;
        }

        internal void Bark()
        {
            Console.WriteLine("{0}, which is {1} years old and of {2} breed is barking", this.Name, this.Age, this.Breed);
        }
    }
}
