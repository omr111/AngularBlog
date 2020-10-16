using Core.DataResult.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataResult.Concrete
{
    public class DataResult<T> : Result, IDataResult<T> where T : class
    {
        public DataResult(T data, string message,bool success):base(success,message)
        {
            this.data = data;
        }
      
        public T data { get ; }
      
    }
}
