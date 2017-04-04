using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn
{
   public class LogAnalyzer
    {
        private IWebService service;
        private IExtensionManager manager;

        public LogAnalyzer()
        {
            manager = new FileExtensionManager();
        }

        public LogAnalyzer(IWebService service)
        {
            this.service = service;
        }

        public LogAnalyzer(IExtensionManager mgr)
        {
            this.manager = mgr;
        }

        public void Analyze(string fileName)
        {
            if(fileName.Length < 8)
            {
                throw new Exception("Filename too short : abc.ext");
            }
        }

        public bool IsValidLogFileName(string fileName)
        {
            //    if (String.IsNullOrEmpty(fileName))
            //    {
            //        throw new ArgumentException("No filename provided!");
            //    }
            //    if (!fileName.EndsWith(".slf"))
            //    {
            //        return false;
            //    }
            //    return true;
            //}

            //IExtensionManager mgr = new FileExtensionManager();

            return manager.IsValid(fileName);
        }
    }
}
