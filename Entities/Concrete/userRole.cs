using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class userRole
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }

        public virtual role Role { get; set; }
        public virtual user User { get; set; }
    }
}
