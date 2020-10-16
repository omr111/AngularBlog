using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Core.DataResult.Concrete
{
    public class Result : IResult
    {
    
        public Result(bool success,string message)
        {
            this.success = success;
            this.message = message;
        }
        public Result(bool success)
        {
            this.success = success;
        }
        public bool success { get ; set; }
        public string message { get; set; }
    }
}
