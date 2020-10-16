using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class user
    {
        public user()
        {
            Comments = new HashSet<Comment>();
            Likes = new HashSet<Like>();
            Posts = new HashSet<Post>();
            RoleUsers = new HashSet<userRole>();
            UserContactInfoes = new HashSet<UserContactInfo>();
        }

        public int Id { get; set; }
        public string userName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegisteredDate { get; set; }
        public bool? IsActive { get; set; }
        public string ProfileImgUrl { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<userRole> RoleUsers { get; set; }
        public virtual ICollection<UserContactInfo> UserContactInfoes { get; set; }
    }
}
