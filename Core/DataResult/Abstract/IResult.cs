using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataResult.Abstract
{
    public interface IResult
    {
         bool success { get; set; }
         string message { get; set; }
   
    }
}
