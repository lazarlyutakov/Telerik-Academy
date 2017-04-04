using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class Display
    {
        public int? NumberOfColors { get; set; }
        public double? Size { get; set; }

        public Display(int? numberOfColors = null, double? size = null)
        {
            NumberOfColors = numberOfColors;
            Size = size;
        }
    }
}
