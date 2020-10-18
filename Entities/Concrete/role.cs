using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public  class role
    {
        public role()
        {
            RoleUsers = new HashSet<userRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<userRole> RoleUsers { get; set; }
    }
}
