using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCodes
{
    public class ClassOneTwoThree
    {
        const int MAX_COUNT = 6;

        public static void Main()
        {
            var logger = new MessageLogger();
            logger.LogBooleanAsString(true);
        }
    }
}
