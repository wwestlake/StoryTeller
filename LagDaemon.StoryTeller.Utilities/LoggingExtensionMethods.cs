using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagDaemon.StoryTeller.Utilities
{
    public static class LoggingExtensionMethods
    {
        public static void Info(this ILogger logger, string format, params object[] args)
        {
            string msg = string.Format(format, args);
            logger.Info(msg);
        }
    }
}
