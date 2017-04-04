using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Kitten : Cat
    {


        public override string Gender

        {
            get { return this.gender; }
            protected set
            {
                if (value != "female")
                {
                    throw new ArgumentException();//("Kitten could be only female !");
                }
                this.gender = value;
            }
        }


        public Kitten(string name, int age, string gender) : base(name, age, gender)

        {

        }


    }
}
