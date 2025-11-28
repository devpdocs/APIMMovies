using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.M.Movies.Services;
using API.M.Movies.DAL.Models.Dtos;

namespace API.M.Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryService _categoryService; 

        public CategoriesController(CategoryService categoryService)
        {
            _categoryService = categoryService;

        }

        public async Task<ActionResult<ICollection<CategoryDtos>>> GetCategoriesAsync()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            return Ok(categories);
        }

    }
    
}
