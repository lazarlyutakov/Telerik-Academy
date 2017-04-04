namespace RefactorStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ClassChefInCSharp.Models;

    public class PotatoRefactoring
    {
        public void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }

        public void RefactorPotatoCode()
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                if (potato.HasBeenPeeled() && potato.IsRotten())
                {
                    this.Cook(potato);
                }
            }
        }
    }
}