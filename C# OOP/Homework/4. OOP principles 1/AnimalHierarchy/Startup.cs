using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Startup
    {
        static void Main(string[] args)
        {
            
            Cat[] cats =
             {
                new Tomcat("Tom", 3, "male"),
                new Kitten("Fluffy", 2, "female"),
                new Tomcat("Garfield", 5, "male")
             };


            Dog[] dogs =
            {
                new Dog("Balkan", 4, "male"),
                new Dog("Sharo", 3, "male"),
                new Dog("Req", 5, "female")
            };


            Frog[] frogs =
            {
                new Frog("Kirmit", 6, "male"),
                new Frog("Penka", 1, "female"),
                new Frog("Kvakar", 3, "male")
            };

            //using static method
            Console.WriteLine("The average age of the frogs is : {0:f2} years", AverageAge(frogs));
            Console.WriteLine("The average age of the cats is : {0:f2} years", AverageAge(cats));
            Console.WriteLine("The average age of the dogs is : {0:f2} years", AverageAge(dogs));

            Console.WriteLine();

            // using lambda
            //double avrgFrogs = frogs.Average(x => x.Age);
            //double avrgDogs = dogs.Average(x => x.Age);
            //double avrgCats = cats.Average(x => x.Age);
            //Console.WriteLine("The average age of the frogs is : {0:f2} years", avrgFrogs);
            //Console.WriteLine("The average age of the dogs is : {0:f2} years", avrgDogs);
            //Console.WriteLine("The average age of the cats is : {0:f2} years", avrgCats);
        }

        public static double AverageAge(Animal[] animals)
        {
            double avrg = 0;
            double sumOfAges = 0;

            foreach (var item in animals)
            {
                sumOfAges += item.Age;
            }

           return avrg = sumOfAges / animals.Length;

        }
    }
}
