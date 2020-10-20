using System;
using System.Collections.Generic;

namespace Entities.conc
{
    public partial class Tags
    {
        public Tags()
        {
            PostTag = new HashSet<PostTag>();
        }

        public int Id { get; set; }
        public string TagName { get; set; }

        public virtual ICollection<PostTag> PostTag { get; set; }
    }
}
