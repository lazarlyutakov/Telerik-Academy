using System;
using SchoolSystem.Contracts;
using SchoolSystem.Enums;

namespace SchoolSystem
{
    public class Mark : IMark
    {
        private float markValue;
        private Subject subject;

        public Mark(Subject subject, float markValue)
        {
            this.subject = subject;

            if (markValue < 2 || markValue > 6)
            {
                throw new ArgumentOutOfRangeException("The value of the mark must be between 2 and six");
            }
            else
            {
                this.markValue = markValue;
            }           
        }

        public Subject Subject
        {
            get
            {
                return this.subject;
            }
        }

        public float Value
        {
            get
            {
                return this.markValue;
            }

            set
            {                
                this.markValue = value;
            }
        }                    
    }
}