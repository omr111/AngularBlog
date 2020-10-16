using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
   public class tokenOptions
    {
        
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int accessTokenExpiration { get; set; }
        public string securityKey { get; set; }

    }
}
