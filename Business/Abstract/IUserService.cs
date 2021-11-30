using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserService
    {
        DataResult<List<OperationClaim>> GetClaims(User user);
        IResult Add(User user);
        DataResult<User> GetByMail(string email);
    }
}
