﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemos
{
    class Startup
    {
        static void Main(string[] args)
        {
            Square square = new Square(0, 0, 2);
            Rectangle rectangle = new Rectangle(0, 0, 2, 3);
            Circle circle = new Circle(0, 0, 5);

            if(square is IShape)
            {
                Console.WriteLine("{0} is IShape", square.GetType());
            }

            if(rectangle is IResizable)
            {
                Console.WriteLine("{0} is IResizable", rectangle.GetType());
            }

            if(circle is IResizable)
            {
                Console.WriteLine("{0} is IResizable", circle.GetType());
            }

            IShape[] shapes = { square, rectangle, circle };

            foreach (IShape shape in shapes)
            {
                shape.SetPosition(5, 5);
                Console.WriteLine("Type: {0};  surface: {1}",
                    shape.GetType(), shape.CalculateSurface());
            }

        }
    }
}
