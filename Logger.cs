using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HomeWork4
{
    class Logger
    {
        private static Logger logger;
        public static Logger getInstance()
        {
            if (logger == null)
                logger = new Logger();
            return logger;
        }
        public Log[] Logs { get; set; }
        private Logger()
        {
            Logs = new Log[100];
        }

        public void DisplayLog(Log log)
        {
            Console.WriteLine($"Logger time: {log.Time}, logger type: {log.Type}, {log.Message}. ");
            AddLog(log);
        }

        private void AddLog (Log log)
        {
            for (int i = 0; i < Logs.Length; i++)
            { 
                if (Logs[i] == null)
                {
                    Logs[i] = log;
                    break;
                }
            }
                
        }
    }
}
