using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataResult.Concrete
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message, bool success = false) : base(success, message)
        {

        }
        public ErrorResult(bool success = false) : base(success)
        {

        }
    }
}
