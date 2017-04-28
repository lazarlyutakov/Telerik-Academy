using ConsoleApplication3;
using System;

namespace ConsoleApplication3
{
    public class Mark
    {
        private float value;
        private Subjct subject;

        public Mark(Subjct sbj, float va)
        {
            this.subject = sbj;
            this.value = va;
        }     
    }
}
