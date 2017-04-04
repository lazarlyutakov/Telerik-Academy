namespace Abstraction
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var circle = new Circle(4);
            Console.WriteLine(circle);

            var rectangle = new Rectangle(2, 3);          
            Console.WriteLine(rectangle);
        }
    }
}
