using System;
using SchoolSystem.Enums;


namespace SchoolSystem
{
    public class Mark
    {
        private float markValue;
        private Subject subject;

        public Mark(Subject subject, float markValue)
        {
            this.subject = subject;
            this.Value = markValue;
        }

        public float Value
        {
            get
            {
                return this.markValue;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("The value of the mark must be between 2 and six");
                }
                this.markValue = value;
            }
        }                    
    }
}