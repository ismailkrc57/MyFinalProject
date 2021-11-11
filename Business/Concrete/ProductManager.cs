using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Business.Concrete
{

    public class ProductManager : IProductService
    {
        private IProductDal _iProductDal;
        private ICategoryService _categoryService;

        public ProductManager(IProductDal iProductDal, ICategoryService categoryService)
        {
            _iProductDal = iProductDal;
            _categoryService = categoryService;

        }
        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(), Messages.ProductListed);


        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_iProductDal.Get(p => p.ProductId == id), Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailsDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailsDto>>(_iProductDal.getProductDetails());
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            var result = BusinessRule.Run(CheckIfNumberOfCategoryIsCorrect(), CheckIfProductCountOfCategoryCorrect(product.CategoryId), CheckIfProductNameExists(product.ProductName));
            if (result == null)
            {
                _iProductDal.Add(product);
                return new SuccessResult(Messages.ProductAdded);
            }

            return result;

        }


        public IResult Update(Product product)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Product product)
        {
            throw new NotImplementedException();
        }


        private IResult CheckIfNumberOfCategoryIsCorrect()
        {
            var result = _categoryService.GetAll();
            if (result.Data.Count >= 15)
            {
                return new ErorResult(Messages.CategoryLimitError);
            }

            return new SuccessResult();
        }

        private IResult CheckIfProductNameExists(string productName)
        {
            var result = _iProductDal.GetAll(p => p.ProductName.Equals(productName)).Any();
            if (result)
            {
                return new ErorResult(Messages.ProductNameExistError);
            }

            return new SuccessResult();
        }

        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
        {
            var result = _iProductDal.GetAll(p => p.CategoryId == categoryId).Count;
            if (result >= 10)
            {
                return new ErorResult(Messages.ProductCountOfCategoryError);
            }

            return new SuccessResult();
        }
    }
}
