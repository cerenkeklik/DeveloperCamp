using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message): this(success)
        {
            //Read-only ler constructorda set edilebilir.
          
            Message = message;
        }

        public Result(bool success)
        {
            //Read-only ler constructorda set edilebilir.
            Success = success;
           
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
