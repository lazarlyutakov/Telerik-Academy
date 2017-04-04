using System;

    class Program
    {
        static void Main(string[] args)
        {
        string dayOfbirht = (Console.ReadLine()); //тук задаваме кога сме родени. Променливата е от типа "string" и се чете от конзолата.
        DateTime bday = Convert.ToDateTime(dayOfbirht); //тук променливата "bday" е от "специалния" клас/метод DateTime, който борави с време/дати.
        DateTime zeroTime = new DateTime(1, 1, 1);//"нулево време" - дифоулт настройка, за да работи коректно (по причина, че сме в Грегорианския календар и той започва от 01.01.01г.)
        DateTime today = DateTime.Now;//тази функция на метода ни присвоява моментата дата и час на променливата "today";
        TimeSpan span = today - bday;//тук получаваме разликата между датите;
        int years = (zeroTime + span).Year - 1; // тук вадиме добавената "грегорианска година" и присвояваме стойността на променливата "years";
        Console.WriteLine(years);// отпечатваме годините;
        Console.WriteLine(years + 10);//отпечатваме на колко ще сме като го одъртим с 10г. :))))
    }
    }

