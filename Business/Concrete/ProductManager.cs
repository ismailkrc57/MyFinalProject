using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Business.Concrete
{

    public class ProductManager : IProductService
    {
        private IProductDal iProductDal;

        public ProductManager(IProductDal iProductDal)
        {
            this.iProductDal = iProductDal;
        }
        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>(iProductDal.GetAll(), Messages.ProductListed);


        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(iProductDal.Get(p => p.ProductId == id), Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(iProductDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(iProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailsDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailsDto>>(iProductDal.getProductDetails());
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {


            iProductDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }
    }
}
