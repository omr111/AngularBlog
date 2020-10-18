using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public  class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
            Likes = new HashSet<Like>();
            PostTag = new HashSet<PostTag>();
        }

        public int Id { get; set; }
        public string BackgroundImgUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReadCount { get; set; }
        public bool IsActive { get; set; }
        public int? UserId { get; set; }
        public int CategoryId { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public virtual Category Category { get; set; }
        public virtual user User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<PostTag> PostTag { get; set; }
    }
}
