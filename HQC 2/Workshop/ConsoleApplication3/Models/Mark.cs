using System;
using SchoolSystem.Contracts;
using SchoolSystem.Enums;

namespace ScoolSystem.Models
{
    public class Mark : IMark
    {
        private const float MinMarkValue = 2.0f;
        private const float MaxMarkValue = 6.0f;

        public Mark(Subject subject, float markValue)
        {
            this.Subject = subject;

            if (markValue < MinMarkValue || markValue > MaxMarkValue)
            {
                throw new ArgumentOutOfRangeException("The value of the mark must be between 2 and 6!");
            }

            this.MarkValue = markValue;
        }

        public Subject Subject { get; }

        public float MarkValue { get; }
    }
}
