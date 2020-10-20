using System;
using System.Collections.Generic;

namespace Entities.conc
{
    public partial class Logs
    {
        public int Id { get; set; }
        public string LogDetail { get; set; }
        public DateTime LogDate { get; set; }
        public string Audit { get; set; }
    }
}
