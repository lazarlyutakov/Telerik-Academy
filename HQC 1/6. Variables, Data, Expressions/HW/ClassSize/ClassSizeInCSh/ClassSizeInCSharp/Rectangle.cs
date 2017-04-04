using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSizeInCSharp
{
    public class Rectangle
    {
        private double width;
        private double heigth;

        public Rectangle(double width, double heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public static Rectangle GetRotatedSize(Rectangle rectangle, double angleOfFigure)
        {
            var angleOfFigureCosinus = Math.Abs(Math.Cos(angleOfFigure));
            var angleOfFigureSinus = Math.Abs(Math.Sin(angleOfFigure));

            var width = (angleOfFigureSinus * rectangle.width) + (angleOfFigureCosinus * rectangle.heigth);
            var heigth = (angleOfFigureCosinus * rectangle.width) + (angleOfFigureSinus * rectangle.heigth);

            var outputRectangle = new Rectangle(width, heigth);

            return outputRectangle;
        }
    }
}
