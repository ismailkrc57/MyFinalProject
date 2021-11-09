using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    interface IOrderDal:IEntityRepository<Order>
    {
    }
}
