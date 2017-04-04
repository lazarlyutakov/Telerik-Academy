namespace QualityMethods.Calculations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class. that contains methods, facilitating certain mathematical operations.
    /// </summary>
    public class MathAssistant
    {
        public MathAssistant()
        {
        }

        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides must be greater than zero!");
            }

            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

            return area;
        }

        /// <summary>
        /// Calculates the distance between two points.
        /// </summary>
        /// <param name="x1">First point coordinate x.</param>
        /// <param name="y1">First point coordinate y.</param>
        /// <param name="x2">Second point coordinate x.</param>
        /// <param name="y2">Second point coordinate y.</param>
        /// <returns>Returns the calculated distance between two points.</returns>
        internal static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distanceX = x2 - x1;
            double distanceY = y2 - y1;

            double distance = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));

            return distance;
        }

        /// <summary>
        /// Checks if a line is purely horizontal.
        /// </summary>
        /// <param name="x1">First point coordinate x.</param>
        /// <param name="y1">First point coordinate y.</param>
        /// <param name="x2">Second point coordinate x</param>
        /// <param name="y2">Second point coordinate y</param>
        /// <returns>True or false</returns>
        internal static bool IsLineHorizontal(double x1, double y1, double x2, double y2)
        {
            if (y1 == y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a line is purely vertical.
        /// </summary>
        /// <param name="x1">First point coordinate x.</param>
        /// <param name="y1">First point coordinate y.</param>
        /// <param name="x2">Second point coordinate x</param>
        /// <param name="y2">Second point coordinate y</param>
        /// <returns>True or false</returns>
        internal static bool IsLineVertical(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static int FindMaxValue(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("No elements to evaluate.");
            }

            int maxValue = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (maxValue < elements[i])
                {
                    maxValue = elements[i];
                }
            }

            return maxValue;
        }
    }
}
