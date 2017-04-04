using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakovBookTaskN5
{
    class Startup
    {
        //5. Define an abstract class Shape with abstract method CalculateSurface() and fields width and height. 
        //Define two additional classes for a triangle and a rectangle, which implement CalculateSurface(). 
        //This method has to return the areas of the rectangle (height*width) and the triangle (height*width/2). 
        //Define a class for a circle with an appropriate constructor, which initializes the two fields (height and width) 
        //with the same value (the radius) and implement the abstract method for calculating the area. 
        //Create an array of different shapes and calculate the area of each shape in another array.


        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5,6);

            Console.WriteLine(rect.Width);
            Console.WriteLine(rect.Height);

            

            Console.WriteLine(rect.CalculateSurface(rect.Width, rect.Height));
            
        }
    }
}
