namespace RefactorStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RefactorExpression
    {
        public static void ShouldVisitCell(int firstNumb, int minFirstNumb, int maxFirstNumb, int secondNumb, int minSecondNumb, int maxSecondNumb)
        {
            var cellShouldBeVisited = ShouldCellBeVisited(firstNumb, secondNumb);
            var cellIsInBounds = AreCellCoordinatesInLimits(firstNumb, minFirstNumb, maxFirstNumb, secondNumb, minSecondNumb, maxSecondNumb);

            if (cellIsInBounds && cellShouldBeVisited)
            {
                VisitCell(firstNumb, secondNumb);
            }
        }

        public static void VisitCell(int x, int y)
        {
            throw new NotImplementedException();
        }

        public static bool ShouldCellBeVisited(int firstNumb, int secondNumb)
        {
            throw new NotImplementedException();
        }

        public static bool AreCellCoordinatesInLimits(int firstNumb, int minFirstNumb, int maxFirstNumb, int secondNumb, int minSecondNumb, int maxSecondNumb)
        {
            throw new NotImplementedException();
        }
    }
}
}
