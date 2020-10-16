using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Category
    {
        public Category()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
