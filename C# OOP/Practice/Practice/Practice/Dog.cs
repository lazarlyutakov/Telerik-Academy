using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
   public class Dog
    {
        static int dogCount = 0;

        private int age;
        private string name;

        public Dog()
        {
        }

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            Dog.dogCount += 1;
        }



        //static void Main()
        //{
        //    Dog dog1 = new Dog("Jackie", 1);
        //    Dog dog2 = new Dog("Lassy", 2);
        //    Dog dog3 = new Dog("rex", 3);


        //    Console.WriteLine(Dog.dogCount);
        //}
    }
}
