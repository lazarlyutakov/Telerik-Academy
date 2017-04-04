using System;

class PointCircleRectangular
{
    static void Main()
    {

        float x = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        float y = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        float radius = 1.5f;
        float Dist = (float)Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));


        if (x >= -1000 && x <= 1000 && y >= -1000 && y <= 1000)
        {
            bool inCircle = Dist <= radius;
            bool inRectangular = (x >= -1) && (x <= (-1 + 6)) && (y <= 1) && (y >= (1 - 6));

            if (inCircle != true && inRectangular != true)
            {
                Console.WriteLine("outside circle outside rectangle");
            }

            else if (inCircle == true && inRectangular == true)
            {
                Console.WriteLine("inside circle inside rectangle");
            }

            else if (inCircle == true && inRectangular != true) 
            {
                Console.WriteLine("inside circle outside rectangle");
            }

            else
            {
                Console.WriteLine("outside circle inside rectangle");
            }
        }


    }
}

