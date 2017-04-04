using PersonCreator.Enumarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCreator
{
    public class Person
    {
        private string name;
        private int age;
        private Gender gender;

        public Person(int age)
        {
            this.Age = age;

            if (age % 2 == 0)
            {
                this.Name = "Tough Balkan Gangster";
                this.Gender = Gender.Male;
            }
            else
            {
                this.Name = "Ultra Hot Folk Chick";
                this.Gender = Gender.Female;
            }
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}
