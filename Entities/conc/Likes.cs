using System;
using System.Collections.Generic;

namespace Entities.conc
{
    public partial class Likes
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime LikedDate { get; set; }

        public virtual Posts Post { get; set; }
        public virtual Users User { get; set; }
    }
}
