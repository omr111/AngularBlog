using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
   public class ErrorDetails
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public override string ToString()
        {
            //ErrorDetail classını serilize et demek "this"
            return JsonConvert.SerializeObject(this);
        }
    }
}
