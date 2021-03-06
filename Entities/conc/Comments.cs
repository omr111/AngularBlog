﻿using System;
using System.Collections.Generic;

namespace Entities.conc
{
    public partial class Comments
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime AddedDate { get; set; }

        public virtual Posts Post { get; set; }
        public virtual Users User { get; set; }
    }
}
