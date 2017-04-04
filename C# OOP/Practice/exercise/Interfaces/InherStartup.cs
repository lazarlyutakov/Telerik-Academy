using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    class InherStartup
    {
        static void Main(string[] args)
        {
            Puppy Rex = new Puppy("Sharo", 3, "labrador", 20);
            Rex.Sleep();
            Console.WriteLine("Breed : " + Rex.Breed);
            Rex.WagTail();
            Rex.Talk();
            Rex.Walk();
            Rex.Poop();
            
        }
    }
}
