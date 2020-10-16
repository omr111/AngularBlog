using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Log
    {
        public int id { get; set; }
        public string logDetail { get; set; }
        public DateTime logDate { get; set; }
        [MaxLength(50)]
        public string Audit { get; set; }

    }
}
