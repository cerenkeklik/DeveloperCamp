using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
   public interface ITokenHelper
    {
     //İlgili kullanıcı için, ilgili kullanıcının claimleri içeren bir token üretir.
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
