using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretenceAccessiblity
{
    class Startup
    {
        static void Main(string[] args)
        {
            Dog rex = new Dog("Rex", 3, "labrador");

            rex.Sleep();
            rex.Bark();
            rex.Talk();
        }
    }
}
