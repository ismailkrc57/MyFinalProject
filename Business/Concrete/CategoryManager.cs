using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Exception;
using Core.CrossCuttingConcerns.Logging.Serilog.Logers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    [ExceptionLogAspect(typeof(ConsoleLogger))]
    [ExceptionLogAspect(typeof(FileLogger))]
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal iCategoryDal;

        public CategoryManager(ICategoryDal iCategoryDal)
        {
            this.iCategoryDal = iCategoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(iCategoryDal.GetAll(), Messages.CategoryListed);
        }

        public IDataResult<Category> GetByCategoryId(int id)
        {
            return new SuccessDataResult<Category>(iCategoryDal.Get(c => c.CategoryId == id), Messages.CategoryListed);
        }
    }
}
