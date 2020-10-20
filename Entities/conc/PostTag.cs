using System;
using System.Collections.Generic;

namespace Entities.conc
{
    public partial class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }

        public virtual Posts Post { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
