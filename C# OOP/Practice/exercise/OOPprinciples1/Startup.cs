using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheretence
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog rex = new Dog(3, "dakel");
            rex.Sleep();
            rex.WagTail();

            Console.WriteLine("Rex is {0} years old dog of breed {1}",rex.Age, rex.Breed);

            Console.WriteLine();

            Cat pissy = new Cat(4, "Siamka", "white");
            pissy.Sleep();
            pissy.SayMeoooww();

            Console.WriteLine("Pissy is {0} years old cat of breed {1}, {2} in color.", pissy.Age, pissy.Breed, pissy.Color);

        
        }
    }
}
