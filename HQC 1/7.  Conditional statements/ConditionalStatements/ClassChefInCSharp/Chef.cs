namespace ClassChefInCSharp
{
    using System;
    using ClassChefInCSharp.Abstractions;
    using ClassChefInCSharp.Models;
  
    public class Chef
    {
        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Peel(Vegetable potato)
        {
            throw new NotImplementedException();
        }

        private void Cut(Vegetable potato)
        {
            throw new NotImplementedException();
        }
        
        public void Cook()
        {
            Bowl bowl;
            bowl = this.GetBowl();

            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            
            this.Peel(potato);
            this.Peel(carrot);
            
            this.Cut(potato);
            this.Cut(carrot);
            
            bowl.Add(carrot);
            bowl.Add(potato);
        }
    }
}
