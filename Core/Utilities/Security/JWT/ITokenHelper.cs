﻿using System.Collections.Generic;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken createAccessToken(User user, List<OperationClaim> claims);
    }
}
