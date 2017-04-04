using LogAn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn
{
    public class StubExtensionManager : IExtensionManager
    {
        public bool ShouldExtensionBeValid;

        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}
