namespace Abstraction.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Figure
    {
        private const string MessageTemplate = "I am a {0}. My perimeter is {1:f2}. My surface is {2:f2}.";

        public Figure()
        {
        }

        public override string ToString()
        {
            var outputeMessage = string.Format(MessageTemplate, this.GetType().Name, this.CalculatePerimeter(), this.CalculateSurface());

            return outputeMessage;
        }

        protected abstract double CalculatePerimeter();

        protected abstract double CalculateSurface();
    }
}