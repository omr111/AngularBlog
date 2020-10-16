using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataResult.Concrete
{
   public class SuccessResult:Result  
    {
        public SuccessResult(string message,bool success=true):base(success,message)
        {

        }
        public SuccessResult(bool success=true):base(success)
        {

        }
    }
}
