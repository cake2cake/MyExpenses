using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyExpenses.Api.Data;
using MyExpenses.Domain.Models;

namespace MyExpenses.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ApiDbContext _db;
        public CategoryController(ApiDbContext apiDbContext) { 
        
            _db = apiDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            var categories = new List<Category>();

            categories = await _db.Categories.AsNoTracking().ToListAsync();
            
            return Ok(categories);
        }
        
    }
}
