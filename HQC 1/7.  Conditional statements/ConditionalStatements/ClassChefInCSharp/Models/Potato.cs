namespace ClassChefInCSharp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ClassChefInCSharp.Abstractions;

    public class Potato : Vegetable
    {
        public Potato()
        {
        }

        public bool HasBeenPeeled()
        {
            throw new NotImplementedException();
        }

        public bool IsRotten()
        {
            throw new NotImplementedException();
        }
    }
}