using System;

class Printing
{
    static void Main()
    {

        int students = int.Parse(Console.ReadLine());
        int sheetsPerStudent = int.Parse(Console.ReadLine());
        double realmPrice = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        int totalSheets = students * sheetsPerStudent;
        double realms = totalSheets / 500.00;
        double result = realmPrice * realms;

        Console.WriteLine("{0:f2}", result);

    }
}

