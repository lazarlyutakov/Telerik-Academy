using System;

    class PointInACircle
    {
        static void Main()
        {
        float x = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        float y = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        float radius = 2.0f;
        float Dist = (float)Math.Sqrt(x * x + y * y);

        if (Dist <= radius) 
        {            
            
            Console.Out.WriteLine("yes {0}",Dist.ToString("0.00"));
        }

        else
        {
            
            Console.Out.WriteLine("no {0}", Dist.ToString("0.00"));
        }

        Console.WriteLine();

        }
    }

