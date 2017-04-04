using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class SystemInfo
    {
        private static double version = 0.1;
        private static string vendor = "Microsoft";

        public static double Version
        {
            get { return version; }
            set { version = value; }
        }
        public static string Vendor { get; set; }
    }
}
