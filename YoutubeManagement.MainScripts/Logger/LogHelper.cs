using System;
using System.Collections.Generic;
using System.Text;

namespace InstaTool.MainScripts.Logger
{
    public static class LogHelper
    {
        private static LogBase logger = null;
        public static void Log(string message)
        {
            if(logger == null)
            {
                logger = new TextLogger();
            }
            logger.Log(message);
        }
    }
}
