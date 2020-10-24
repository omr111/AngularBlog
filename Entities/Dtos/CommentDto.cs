using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
   public class CommentDto
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public DateTime AddedDate { get; set; }
        public userDto_forComment User { get; set; }

    }
}
