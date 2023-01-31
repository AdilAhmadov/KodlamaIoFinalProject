using BusnessLayer.Abstract;
using EntityLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        int counter;
        IProductService productService;
        public ProductsController(IProductService _productService) 
        { 
            productService= _productService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll() 
        { 
            var result = productService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getten")]
        public IActionResult GetTopTen()
        {
            var result = productService.GetTopTen(counter,10);
            counter += 10;
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult Get(int id)
        {
            var result = productService.GetByID(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addproduct")]
        public IActionResult AddProduct(Product product)
        {
            var result = productService.Add(product);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("deleteproduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var delete = productService.GetByID(id).Data;
            var result = productService.Delete(delete);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("updateproduct")]
        public IActionResult EditProduct(Product product)
        {
            var updateProduct = productService.GetByID(product.ProductID).Data;
            var result = productService.Update(updateProduct);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
