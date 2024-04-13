using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyExpenses.Api.Data;
using MyExpenses.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyExpenses.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCatController : ControllerBase
    {
        ApiDbContext _db;
        public SubCatController(ApiDbContext apiDbContext)
        {
            _db = apiDbContext;
        }

        // GET: api/<SubCatController>
        [HttpGet]
        public async Task<ActionResult<List<SubCat>>> GetSubCats()
        {

            var subCats = new List<SubCat>();
            
            subCats = await _db.SubCats.Include(sc => sc.Category).OrderBy(sc => sc.Category.CatOrder).AsNoTracking().ToListAsync();            
            
            return Ok(subCats);
        }
       
    }
}
