using System;
using System.Collections.Generic;

namespace Entities.conc
{
    public partial class Categories
    {
        public Categories()
        {
            Posts = new HashSet<Posts>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }
    }
}
