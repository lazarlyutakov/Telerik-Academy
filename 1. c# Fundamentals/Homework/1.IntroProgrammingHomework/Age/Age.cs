using System;

class Age
{
    static void Main()
    {
        string BirthDay = Console.ReadLine();
        DateTime DateOfBirth = DateTime.ParseExact(BirthDay, "MM.dd.yyyy", null);
        DateTime now = DateTime.Now;

        int age;
        

        if (now.Month >= DateOfBirth.Month)
        {
            age = now.Year - DateOfBirth.Year;
        }
        else
            age = now.Year - DateOfBirth.Year - 1;
                if(age>=0)
                 {
            age = now.Year - DateOfBirth.Year;
                 }
                else
                    {
                        Console.WriteLine("Incorrect Input");
                    }

        if (now.Day < DateOfBirth.Day && now.Month == DateOfBirth.Month)
        {
            age--;
        }
        

        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}