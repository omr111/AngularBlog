using Core.DataResult.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataResult.Concrete
{
    public class DataErrorResult<T> : Result, IDataResult<T> where T : class
    {
        public DataErrorResult(T data, string message) : base(false, message)
        {
            this.data = data;
        }
        public DataErrorResult(T data) : base(false)
        {
            this.data = data;
        }
        public DataErrorResult(string message):base(false,message)
        {

        }
        public T data { get ; set; }



    }
}
