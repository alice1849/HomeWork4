using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class Result
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public Result()
        {

        }
        public Result (bool status)
        {
            Status = status;
        }
        public Result(bool status, string message)
        {
            Status = status;
            Message = message;
        }

    }
}
