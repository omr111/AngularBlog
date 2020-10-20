using System;
using System.Collections.Generic;

namespace Entities.conc
{
    public partial class UserContactInfoes
    {
        public int Id { get; set; }
        public string ContactType { get; set; }
        public string LinkAddress { get; set; }
        public string ContactIcon { get; set; }
        public int UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
