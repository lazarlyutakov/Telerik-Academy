using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
       public override string Gender

        {
           get { return this.gender; }
           protected set
            {
                if (value != "male")
                {
                    throw new ArgumentException("Tomcat could be only male !");
                }
                this.gender = value;
            }
        }

        public Tomcat(string name, int age, string gender) : base(name, age, gender)
        {

        }
    }
}
