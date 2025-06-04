using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.API.Core.Contracts;
using WebApplicationDemo.API.Core.Models;

namespace WebApplicationDemo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // id is 1 to get default response
        [HttpGet]
        [Route("GetProductById")]
        public IActionResult GetProduct(int id)
        {
            var result = _productService.GetProduct(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts(int id)
        {
            // get product 
            // return response
            return Ok("hello Many");
        }

        [HttpPost]
        [Route("CreateProduct")]
        public IActionResult PostProduct(Product obj)
        {
            // create product
            // return response
            return Ok("hello Many");
        }
    }
}
