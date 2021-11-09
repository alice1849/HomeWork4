using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class Log
    {
        public DateTime Time { get; set; }
        public LogType Type { get; set; }
        public string Message { get; set; }
        public Log()
        {
            Time = DateTime.Now;
        }
        public Log(string message, LogType type)
        {
            Time = DateTime.Now;
            Message = message;
            Type = type;
        }
        
    }
}
