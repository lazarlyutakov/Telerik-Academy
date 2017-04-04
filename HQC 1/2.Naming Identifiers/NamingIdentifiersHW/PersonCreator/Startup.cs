using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCreator
{
    class Startup
    {
        static void Main()
        {
            Person createdPerson = new Person(30);
            Console.WriteLine(createdPerson.Gender);
        }
    }
}
