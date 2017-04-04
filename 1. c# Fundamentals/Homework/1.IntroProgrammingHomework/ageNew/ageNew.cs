using System;

    class ageNew
    {
    static void Main(string[] args)
        {
        string BirthDay = Console.ReadLine();
        DateTime DateOfBirth = DateTime.ParseExact(BirthDay, "MM.dd.yyyy", null);
        DateTime now = DateTime.Now;

        for (int age = now.Month - DateOfBirth.Month; age >= 0; age++) ;
            {
            
            }

           
        }
    }

