using System;
using System.Collections.Generic;

namespace Entities.conc
{
    public partial class Users
    {
        public Users()
        {
            Comments = new HashSet<Comments>();
            Likes = new HashSet<Likes>();
            Posts = new HashSet<Posts>();
            UserContactInfoes = new HashSet<UserContactInfoes>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
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
        public string UserName { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Likes> Likes { get; set; }
        public virtual ICollection<Posts> Posts { get; set; }
        public virtual ICollection<UserContactInfoes> UserContactInfoes { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
