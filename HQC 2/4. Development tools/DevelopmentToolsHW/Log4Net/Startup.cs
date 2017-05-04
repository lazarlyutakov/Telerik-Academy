using System;
using log4net;
using log4net.Config;

namespace Log4Net
{
    public class Log4NetHW
    {
        public static void Main(string[] args)
        {
            ILog logger = LogManager.GetLogger(typeof(Log4NetHW));

            XmlConfigurator.Configure();

            // go to Log4Net/bin/Debug/log.txt to see rezult
            logger.Info(DateTime.Now);
            var tt = "Tdjlnvjlnr";
            Console.WriteLine(tt.ToLower());
        }
    }
}
