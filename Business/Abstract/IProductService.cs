using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int productId);
        List<Product> GetAllByCategory(int productId);
        List<Product> GetByUnitPrice(decimal min,decimal max);
        List<ProductDetailDto> GetProductDetails();
        Product Add(Product product);
        Product Update(Product product);
        void Delete(Product product);
        void DeleteById(int productId);
    }
}
