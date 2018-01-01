using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using log4net;
using log4net.Config;

namespace Log4netTest
{
    class Program
    {
        //private static readonly ILog log =
        //log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //public static ILog logger;

        static void Main(string[] args)
        {
            LogUtility.start();

            Console.WriteLine("Log4net test");

            //logger = LogManager.GetLogger("LogFileAppenderSample");
            for (int i = 0; i < 5; i++)
            {
                LogUtility.Debug("Test log file appender sample logger..." + i);
            }

            LogUtility.Debug(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
            LogUtility.Debug(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");

            Console.WriteLine("PRESS a key to close...");

            //log.Info("Application is working");
        }
    }
}
