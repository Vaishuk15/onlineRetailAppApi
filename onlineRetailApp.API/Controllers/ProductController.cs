using OnlineRetailApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using OnlineRetailApp.Models.ViewModel;
using OnlineRetailApp.Repository.EntityModel;
using System;

namespace OnlineRetailApp.API.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

      

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(_productService.Get());
        }

        [HttpGet("getById/{id}")]
        public IActionResult getById(Guid id)
        {
            Product product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound("The Product record couldn't be found.");
            }
            return Ok(product);
        }


        [HttpGet("getByName/{name}")]
        public IActionResult getByName(String name)
        {
            Product product = _productService.GetByName(name);
            if (product == null)
            {
                return NotFound("The Product record couldn't be found.");
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Add([FromBody] ProductViewModel productViewModel)
        {
            _productService.Add(productViewModel);
            return Ok("Product Added!");
        }


       [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _productService.Delete(id);
            return Ok("Product Deleted!");
        }

        
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] ProductViewModel productViewModel)
        {
            _productService.Update(id, productViewModel);
            return Ok("Product Updated!");
        }

    }
}
