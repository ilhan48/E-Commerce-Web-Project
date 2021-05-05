using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal:IProductDal
    {
        public List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{CategoryId = 1,ProductId = 1,ProductName = "Phone",UnitPrice = 1500,UnitsInStock = 15},
                new Product{CategoryId = 2,ProductId = 2,ProductName = "Computer",UnitPrice = 10000,UnitsInStock = 10},
                new Product{CategoryId = 2,ProductId = 3,ProductName = "Mouse",UnitPrice = 153,UnitsInStock = 50},
                new Product{CategoryId = 2,ProductId = 4,ProductName = "Keyboard",UnitPrice = 300,UnitsInStock = 60},
                new Product{CategoryId = 3,ProductId = 5,ProductName = "TV",UnitPrice = 3000,UnitsInStock = 5}
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
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
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
