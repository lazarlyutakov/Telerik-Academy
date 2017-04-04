using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Display
    {
        private float size;
        private ulong numbOfColors;

        public float Size { get; set; }
        public ulong NumbOfColors { get; set; }

        public Display()
        {
        }

        public Display(float size, ulong numbOfColors)
        {
            this.Size = size;
            this.NumbOfColors = numbOfColors;
        }
    }
}
