using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataResult.Abstract
{
  public  interface IDataResult<T> :IResult where T:class
    {
         T data { get; }
 

    }
}
