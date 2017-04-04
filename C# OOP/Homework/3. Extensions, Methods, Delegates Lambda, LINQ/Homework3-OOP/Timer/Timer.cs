using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Timer
{
    class Timer
    {
        private int interval;
        private int time;
        private int counter;

        public delegate void ActionsToPerform();
        public ActionsToPerform InternalMethods;

        public int Counter { get; set; }

        public Timer(int interval, int time)
        {
            this.interval = interval;
            this.time = time;
        }

        public Timer() : this(0, 30) { }


        public void Start()
        {
            DateTime end = DateTime.Now.AddSeconds(time);
            while (DateTime.Now < end)
            {
                InternalMethods();
                Thread.Sleep(interval * 1000);
                counter++;
            }
        }

    }
}
