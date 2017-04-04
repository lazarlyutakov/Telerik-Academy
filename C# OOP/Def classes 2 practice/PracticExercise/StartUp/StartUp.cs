using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class StartUp
    {
        static void Main()
        {
            SystemInfo systemInfoInstance = new SystemInfo();
            Console.WriteLine(SystemInfo.Version);

        }
    }
}
