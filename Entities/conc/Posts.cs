using System;
using System.Collections.Generic;

namespace Entities.conc
{
    public partial class Posts
    {
        public Posts()
        {
            Comments = new HashSet<Comments>();
            Likes = new HashSet<Likes>();
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

        public virtual Categories Category { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Likes> Likes { get; set; }
        public virtual ICollection<PostTag> PostTag { get; set; }
    }
}
