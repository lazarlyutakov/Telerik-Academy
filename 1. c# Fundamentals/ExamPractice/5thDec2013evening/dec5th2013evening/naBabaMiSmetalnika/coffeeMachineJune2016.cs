using System;

class coffeeMachineJune2016
{
    static void Main()
    {
        int tray1 = int.Parse(Console.ReadLine());
        int tray2 = int.Parse(Console.ReadLine());
        int tray3 = int.Parse(Console.ReadLine());
        int tray4 = int.Parse(Console.ReadLine());
        int tray5 = int.Parse(Console.ReadLine());

        double amountToPut = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double price = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        double moneyInMachine = 0.05 * tray1 + 0.10 * tray2 + 0.20 * tray3 + 0.50 * tray4 + 1.00 * tray5;
        double change = amountToPut - price;
        double moneyLeft = moneyInMachine - change;


         if (amountToPut > price && moneyInMachine < change)
        {
            Console.WriteLine("No {0:f2}", (change - moneyInMachine));
        }

        else if (amountToPut >= price)
        {
            Console.WriteLine("Yes {0:f2}" , (moneyInMachine - change));
        }
        else if (amountToPut < price)
        {
            Console.WriteLine("More {0:f2}", (price - amountToPut));
        }
        

    }
}
