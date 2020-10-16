using Core.DataResult.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataResult.Concrete
{
    public class DataSuccessResult<T> : Result, IDataResult<T> where T : class
    {
        public DataSuccessResult(T data,string message):base(true,message)
        {
            this.data = data;
        }
        public DataSuccessResult(T data):base(true)
        {
            this.data = data;
        }
        public T data { get; set ; }
      
    }
}
