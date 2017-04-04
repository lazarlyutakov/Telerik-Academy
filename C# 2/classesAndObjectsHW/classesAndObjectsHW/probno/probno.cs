using System;


namespace probno
{

    class IsLeap
    {
        public IsLeap(int year)
        {
            Year = year;

        }


        public int Year { get; private set; }


        public bool isLeap
        {
            get
            {
                bool isLeap = true;

                if (DateTime.IsLeapYear(Year) == isLeap)
                {
                    return isLeap;
                }
                else
                {
                    return false;
                }
            }
        }

        public static void LeapOrCommon()
        {
            
        }
    }




    class probno
    {
        static void Main()
        {
            int inputYear = int.Parse(Console.ReadLine());
            IsLeap yearTocheck = new IsLeap(inputYear);

            Console.WriteLine(yearTocheck.isLeap);
        }
    }
}
