using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public  class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime AddedDate { get; set; }

        public virtual Post Post { get; set; }
        public virtual user User { get; set; }
    }
}
