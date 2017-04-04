namespace ClassChefInCSharp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ClassChefInCSharp.Abstractions;
    using ClassChefInCSharp.Contracts;

    public class Bowl : IBowl
    {      
        public Bowl()
        {            
        }

        public List<Vegetable> Vegetables { get; set; }

        public void Add(Vegetable vegetable)
        {
            this.Vegetables.Add(vegetable);
        }
    }
}
