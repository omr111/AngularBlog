using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
   public class PostDetailDto:postDto
    {
        public List<tagDto> tags { get; set; }
        public AuthorForPostDto author { get; set; }
        public List<CommentDto> comments { get; set; }
    }
}
