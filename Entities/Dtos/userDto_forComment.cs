using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class userDto_forComment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string ProfileImgUrl { get; set; }
        public string UserName { get; set; }
        public bool? IsActive { get; set; }
    }
}
