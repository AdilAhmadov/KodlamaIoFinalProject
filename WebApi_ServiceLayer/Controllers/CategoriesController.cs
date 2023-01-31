using BusnessLayer.Abstract;
using EntityLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService categoryService;
        public CategoriesController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = categoryService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid/{id}")]
        public IActionResult Get(int id)
        {
            var result = categoryService.GetByID(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addproduct")]
        public IActionResult AddProduct(Category category)
        {
            var result = categoryService.Add(category);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("deleteproduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var delete = categoryService.GetByID(id).Data;
            var result = categoryService.Delete(delete);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("updateproduct")]
        public IActionResult EditProduct(Category category)
        {
            var updateCategory = categoryService.GetByID(category.CategoryID).Data;
            var result = categoryService.Update(updateCategory);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
