using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class Dog
    {

        static int dogCount = 0;

        private int age;
        private string name;

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            Dog.dogCount += 1;
        }

        public void Bark()
        {
            Console.WriteLine("Bau Bau");
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.name + " " + this.age);
            this.Bark();
        }

        //static void Main()
        //{

        //    Dog dog1 = new Dog("Jessy", 1);

        //    dog1.PrintInfo();
        //}


    }
}
