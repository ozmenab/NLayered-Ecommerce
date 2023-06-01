using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return _productService.GetAll();
        }
        [HttpGet("{id}")]
        public Product GetById(int id)
        {
            return _productService.GetById(id);
        }

        [HttpPost]
        public Product Add(Product product)
        {
            //ValidationTool.Validate(new ProductValidator(), product);
            return _productService.Add(product);
        }
        [HttpPut]
        public Product Update(Product product)
        {
            return _productService.Update(product);
        }
        [HttpDelete]
        public void DeleteById(int id)
        {
            _productService.DeleteById(id);
        }
        
    }
}
