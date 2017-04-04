namespace ClassChefInCSharp.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ClassChefInCSharp.Abstractions;

    public interface IBowl
    {
        void Add(Vegetable vegetable);           
    }
}
