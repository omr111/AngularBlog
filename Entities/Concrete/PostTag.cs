using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public  class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }

        public virtual Post Post { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
