using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HomeWork4
{
    class Actions
    {

        public Result Method1 ()
        {
            Log log = new Log("Start method 1", LogType.Info);
            Result result = new Result(true);
            Logger logger = Logger.getInstance();
            logger.DisplayLog(log);
            return result;
        }
        public Result Method2()
        {
            Log log = new Log("Start method 2", LogType.Warning);
            Result result = new Result(true);
            Logger logger = Logger.getInstance();
            logger.DisplayLog(log);
            return result;
        }
        public Result Method3()
        {
            Result result = new Result(false, "I broke a logic");
            return result;
        }


    }
}
