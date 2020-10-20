using System;
using System.Collections.Generic;

namespace Entities.conc
{
    public partial class UserRoles
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }

        public virtual Roles Role { get; set; }
        public virtual Users User { get; set; }
    }
}
