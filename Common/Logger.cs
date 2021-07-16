using NLog;
using System.IO;

namespace Common
{
    public static class Logger
    {
        private static NLog.Logger loggerInfo = LogManager.GetLogger("info");
        private static NLog.Logger loggerError = LogManager.GetLogger("error");
        private static NLog.Logger logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// info
        /// </summary>
        /// <param name="methodName"></param>
        public static void Start(string methodName)
        {
            loggerInfo.Info($"[{methodName}]Start");
        }

        /// <summary>
        /// error
        /// </summary>
        /// <param name="message"></param>
        public static void Error(string message)
        {
            loggerError.Error(message);
        }

        /// <summary>
        /// debug
        /// </summary>
        /// <param name="message"></param>
        public static void Common(string message)
        {
            logger.Debug(message);
        }
    }
}


