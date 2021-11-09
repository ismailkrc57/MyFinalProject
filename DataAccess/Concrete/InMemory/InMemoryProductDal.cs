using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product()
                    { ProductId = 1, CategoryId = 1, ProductName = "bardak", UnitPrice = 15, UnitsInStock = 12 },
                new Product()
                    { ProductId = 2, CategoryId = 1, ProductName = "kamera", UnitPrice = 500, UnitsInStock = 3 },
                new Product()
                    { ProductId = 3, CategoryId = 2, ProductName = "telefon", UnitPrice = 1500, UnitsInStock = 2 },
                new Product()
                    { ProductId = 4, CategoryId = 2, ProductName = "kalvye", UnitPrice = 150, UnitsInStock = 65 },
                new Product()
                    { ProductId = 5, CategoryId = 2, ProductName = "fare", UnitPrice = 85, UnitsInStock = 15 }
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filterExpression = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
            }
        }

        public void Delete(Product product)
        {
            Product productToDelte = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelte);
        }

        public List<ProductDetailsDto> getProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
