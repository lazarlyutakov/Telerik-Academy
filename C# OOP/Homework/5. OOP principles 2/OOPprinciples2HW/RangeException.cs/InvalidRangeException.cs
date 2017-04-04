using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeException.cs
{
    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string baseMessage, T start, T end) : base(baseMessage)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; private set; }
        public T End { get; private set; }
    }
}
