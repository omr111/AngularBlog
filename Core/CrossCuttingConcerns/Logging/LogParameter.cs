using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging
{
  public  class LogParameter
    {
        public string name { get; set; }
        public object value { get; set; }
        public string type { get; set; }

    }
}
