using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace Log4netTest
{
    class LogUtility
    {
        public static ILog logger;

        public static void start()
        {
            //XmlConfigurator.Configure(new System.IO.FileInfo(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "//Log4net.config"));
            XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));
            logger = LogManager.GetLogger("LogFileAppenderSample");
        }

        public static void Debug(String msg)
        {
            logger.Debug(msg);
        }

    }
}
