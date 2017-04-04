using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn
{
   public class LogAnalyzer2
    {
        private IWebService service;
        private IEmailService email;

        public IWebService Service
        {
            get
            {
                return service;
            }
            set
            {
                this.service = value;
            }
        }

        public IEmailService Email
        {
            get
            {
                return email;
            }
            set
            {
                this.email = value;
            }
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                if (fileName.Length < 8)
                {
                    try
                    {
                        service.LogError("Filename too short:" + fileName);
                    }
                    catch (Exception e)
                    {
                        email.SendEmail("a", "subject", e.Message);
                    }
                }
            }
        }
    }
}
