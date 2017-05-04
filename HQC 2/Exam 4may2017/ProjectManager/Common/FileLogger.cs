using log4net;

namespace ProjectManager.Common
{
    public class FileLogger
    {
        private static ILog log;

        static FileLogger()
        {
            log = LogManager.GetLogger(typeof(FileLogger));
        }

        public void Info(string message)
        {
            log.Info(message);
        } 
               
        public void Error(string message)
        {
             log.Error(message);
        } 
               
        public void Fatal(string message)
        {
            log.Fatal(message);
        }
    }
}
