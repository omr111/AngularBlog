using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public  class Like
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime LikedDate { get; set; }

        public virtual Post Post { get; set; }
        public virtual user User { get; set; }
    }
}
