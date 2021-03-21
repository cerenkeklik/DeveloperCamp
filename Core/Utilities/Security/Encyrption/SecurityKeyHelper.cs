using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encyrption
{
    public class SecurityKeyHelper
    {
        //Stringlerle encryptiona parametre geçemezsin. Byte array haline getirmen lazım. 
       
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
           //Byte ını alıp onu bir simetrik anahtar haline getirmeye yarar
           //JWT ihtiyaç duyuyor
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
