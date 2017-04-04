using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretenceAccessiblity
{
    class Creature
    {
        public string Name { get; set; }

        public Creature(string name)
        {
            this.Name = name;
        }

        public void Talk()
        {
            Console.WriteLine("Q sym dzver");
        }

        protected void Walk()
        {
            Console.WriteLine("Walking...");
        }



    }
}
