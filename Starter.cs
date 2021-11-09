using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HomeWork4
{
    class Starter
    {
        public void Run()
        {
            Random rnd = new Random();
            Actions act = new Actions();
            Result res = new Result();
            for (int i = 0; i < 100; i++)
            {
                switch (rnd.Next(0, 3))
                {
                    case 0:
                        res = act.Method1();
                        break;
                    case 1:
                        res = act.Method2();
                        break;
                    case 2:
                        res = act.Method3();
                        break;
                }
                
                if (res.Status != true)
                {
                    Log log = new Log();
                    log.Message = $"Action failed by a reason: {res.Message}";
                    log.Type = LogType.Error;
                    Logger logger = Logger.getInstance();
                    logger.DisplayLog(log);
                }

            }
            Logger logg = Logger.getInstance();
            string[] array = new string[100];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = $"Logger time: {logg.Logs[j].Time}, logger type: {logg.Logs[j].Type}, {logg.Logs[j].Message}. ";
                j++;
            }
            File.WriteAllLines("log.txt", array);
        }
    }
}
