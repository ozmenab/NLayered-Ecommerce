using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product() {ProductId=1, CategoryId=1, ProductName = "Mouse", UnitPrice = 15, UnitsInStock=15},
                new Product() {ProductId=2, CategoryId=1, ProductName = "Keybord", UnitPrice = 30, UnitsInStock=10},
                new Product() {ProductId=3, CategoryId=2, ProductName = "Monitor", UnitPrice = 1500, UnitsInStock=20}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (productToDelete != null)
            {
                _products.Remove(productToDelete);
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
            return _products.Where(p=> p.CategoryId == CategoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if(productToUpdate != null)
            {
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;
            }
        }

        Product IEntityRepository<Product>.Add(Product entity)
        {
            throw new NotImplementedException();
        }

        Product IEntityRepository<Product>.Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
