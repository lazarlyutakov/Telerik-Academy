using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCodes
{
    internal class MessageLogger
    {
        public void LogBooleanAsString(bool parameter)
        {
            string parameterToString  = parameter.ToString();
            Console.WriteLine(parameterToString);
        }
    }
}
