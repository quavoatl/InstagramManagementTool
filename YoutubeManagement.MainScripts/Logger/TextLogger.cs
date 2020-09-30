using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace InstaTool.MainScripts.Logger
{
    public class TextLogger : LogBase
    {
        string filePath = AppDomain.CurrentDomain.BaseDirectory +
                        $"LogMessage_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}_{DateTime.Now.Hour}_{DateTime.Now.Second}.txt";
        public override void Log(string message)
        {
            File.AppendAllText(filePath, message + Environment.NewLine);
        }
    }
}
