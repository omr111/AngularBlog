using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
 public   class postDto
    {
        public int id { get; set; }
        public string BackgroundImgUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReadCount { get; set; }
        public bool IsActive { get; set; }
        public int commentCount { get; set; }
        public int likeCount { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public CategoryDto category { get; set; }
       
    
       
    }
}
