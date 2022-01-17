using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfLaboratuarSiraDal:EfEntityRepositoryBase<LaboratuarSira,WepAppProjectContext>,ILaboratuarSiraDal
    {
        
    }
}