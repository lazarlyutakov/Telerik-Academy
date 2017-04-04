using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    public class Creature
    {
        protected string Name { get; private set; }

        public Creature(string name)
        {
            this.Name = name;
        }

        public void Talk()
        {
            Console.WriteLine("Q sym dzver...");
        }

        internal void Walk()
        {
            Console.WriteLine("Walk walk...");
        }


    }
}
