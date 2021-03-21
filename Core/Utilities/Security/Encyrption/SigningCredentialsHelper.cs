using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encyrption
{
    public class SigningCredentialsHelper
    {//Hangi anahtar ve hangi algoritmayı kullanacağını söyle.
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha384Signature);
        }
    }
}
