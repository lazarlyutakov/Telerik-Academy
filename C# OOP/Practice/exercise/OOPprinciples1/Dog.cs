using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheretence
{
    class Dog : Mamal
    {
        public string Breed { get; set; }

        public Dog (int age, string breed) : base(age)
        {
            this.Breed = breed;
        }

        public void WagTail()
        {
            Console.WriteLine("tai waggong");
        }


    }
}
