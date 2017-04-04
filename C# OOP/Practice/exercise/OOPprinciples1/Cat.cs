using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheretence
{
    class Cat : Mamal
    {
        public string Breed { get; set; }
        public string Color { get; set; }

        public Cat (int age, string breed, string color) : base(age)
        {
            this.Breed = breed;
            this.Color = color;
        }

        public void SayMeoooww()
        {
            Console.WriteLine("Meeeeowww");
        }
    }

    
}
