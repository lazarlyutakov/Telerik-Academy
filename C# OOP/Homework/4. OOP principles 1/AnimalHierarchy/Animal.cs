using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        internal string gender;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age should be greater or equal to zero !");
                }

                this.age = value;
            }
        }

        public abstract string Gender { get; protected set; }


        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }



        public abstract void AnimalSound();
  

    }
}
