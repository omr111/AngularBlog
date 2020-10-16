using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
   public class loginDto
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }       
        public string password { get; set; }
        public bool isActive { get; set; }
    }
}
