using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper //Hash oluşturma ve onu doğrulama
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash,
            out byte[] passwordSalt)
        {
            //Hash oluştururken hangi algoritmayı kullanacağımızı söylüyoruz
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                //Her kullanıcı için başka bir key oluşturur.
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash,
            byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                //Doğrularken de aynı algoritma ve daha önce oluşturduğumuz saltı kullanarak doğruluyoruz
               var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }
    }
}
